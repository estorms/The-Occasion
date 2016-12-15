using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using The_Occasion.Data;
using The_Occasion.Models;
using The_Occasion.Models.PoemViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace The_Occasion.Controllers
{

    public class PoemController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        public PoemController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
        {
            _userManager = user;
            context = ctx;
        }

        [Authorize]
        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }

        public async Task<IActionResult> AllPoems()
        {
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = await context.Poem.GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> MyPoems()
        {
            UserSelectionViewModel model = new UserSelectionViewModel(context);
            //identify the current user, which will be coerced to the userId
            var user = await GetCurrentUserAsync();
            //identify all of the user selections by the user Id
            var userSelections = await context.UserSelection.Where(u => u.User == user).ToListAsync();
            //grab all of the poems from the database
            var Poems = await context.Poem.ToListAsync();
            //match user selection poem id's with poem ideas and add each poem to the view model
            foreach (var u in userSelections)
            {
                foreach (var p in Poems)
                {
                    if (p.PoemId == u.PoemId)
                    {
                        model.UserPoems.Add(p);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mood([FromRoute] int? id)
        {
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = await context.Poem.Where(p => p.MoodId == id).GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Form([FromRoute] int? id)
        {
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = await context.Poem.Where(p => p.FormId == id).GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Topic([FromRoute] int? id)
        {
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = await context.Poem.Where(p => p.TopicId == id).GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();

            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Poem([FromRoute]int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            SinglePoemViewModel model = new SinglePoemViewModel(context);
            Poem SinglePoem = await context.Poem.SingleOrDefaultAsync(p => p.PoemId == id);
            model.Poem = SinglePoem;
            string lineString = SinglePoem.Lines;
            var splitStrings = Regex.Split(lineString, "@@");
            model.LinesArray = splitStrings;

            if (model.Poem == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> SavedPoem([FromRoute]int? id)
        {

            SinglePoemViewModel model = new SinglePoemViewModel(context);
            Poem SinglePoem = await context.Poem.SingleOrDefaultAsync(p => p.PoemId == id);
            model.Poem = SinglePoem;
            string lineString = SinglePoem.Lines;
            var splitStrings = Regex.Split(lineString, "@@");
            model.LinesArray = splitStrings;

            if (model.Poem == null)
            {
                return NotFound();
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Bored()
        {

            var AllPoems = await context.Poem.GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();
            SinglePoemViewModel model = new SinglePoemViewModel(context);
            Random random = new Random();
            int r = random.Next(AllPoems.Count);
            model.Poem = AllPoems[r];
            string lineString = model.Poem.Lines;
            var splitStrings = Regex.Split(lineString, "@@");
            model.LinesArray = splitStrings;
            return View(model);

        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Save([FromRoute] int id)
        {

            var user = await GetCurrentUserAsync();
            UserSelection userSelection = new UserSelection();
            userSelection.User = user;
            userSelection.PoemId = id;
            context.UserSelection.Add(userSelection);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var selectionToDelete = await context.UserSelection.Where(u => u.PoemId == id).SingleOrDefaultAsync();
            context.UserSelection.Remove(selectionToDelete);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveBored([FromRoute] int id)
        {

            var user = await GetCurrentUserAsync(); //qpwoeighqwe-234234
            UserSelection userSelection = new UserSelection();
            userSelection.User = user;
            userSelection.PoemId = id;
            context.UserSelection.Add(userSelection);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }

        [Authorize]
        [HttpGet]

        public async Task<IActionResult> MySonnet()
        {
            //create a new instance of the single poem view model to hold the generated poem
            //properties to include on single poem view model: 1.poem, 2. linesarray;

            SinglePoemViewModel model = new SinglePoemViewModel(context);
            //set some dummy properties on model.Poem so that View doesn't freak out

            Poem mySonnet = new Poem();
            mySonnet.Title = "Jessup Jefferson's Poem";
            mySonnet.Author = "Jessup Rides";
            model.Poem = mySonnet;
            //get all the sonnets back from the database
            var sonnets = await context.Poem.Where(p => p.FormId == 118).ToListAsync();

            List<string> SonnetLines = new List<string>();


            //for each sonnet in the list returned from the database, cycle through, split the lines up into individual arrays
            foreach (var sonnet in sonnets)
            {
                var oneSonnetLinesArr = Regex.Split(sonnet.Lines, "@@");
                foreach (var line in oneSonnetLinesArr)
                {
                    SonnetLines.Add(line);
                }

            }

            Random random = new Random();

            var UserSonnet = new string[14];
            for (int i = 0; i < 14; i++)
            {
                int r = random.Next(SonnetLines.Count());
                UserSonnet[i] = SonnetLines[r];
            }

            model.LinesArray = UserSonnet;

            return View(model);
        }


    }
}
