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
            var mood = await context.Mood.SingleOrDefaultAsync(m => m.MoodId == id);
            model.MoodName = mood.MoodName;
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Form([FromRoute] int? id)
        {
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = await context.Poem.Where(p => p.FormId == id).GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();
        
            var form = await context.Form.SingleOrDefaultAsync(f => f.FormId == id);
            model.FormName = form.FormName;
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> Topic([FromRoute] int? id)
        {
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = await context.Poem.Where(p => p.TopicId == id).GroupBy(p => p.Title).Select(p => p.FirstOrDefault()).ToListAsync();
            var topic = await context.Topic.SingleOrDefaultAsync(t => t.TopicId == id);
            model.TopicName = topic.TopicName;
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
            var user = await GetCurrentUserAsync();
            var selectionToDelete = await context.UserSelection.Where(u => u.PoemId == id && u.User == user).SingleOrDefaultAsync();
            context.UserSelection.Remove(selectionToDelete);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }


        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteBored([FromRoute] int id)
        {
            var user = await GetCurrentUserAsync();
            var selectionToDelete = await context.UserSelection.Where(u => u.PoemId == id && u.User == user).SingleOrDefaultAsync();
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
            var user = await GetCurrentUserAsync();
            var userName = user.UserName;
           

            //get all the sonnets back from the database
            var sonnets = await context.Poem.Where(p => p.FormId == 118).ToListAsync();

            //create a list of strings to hold all the individual lines of each sonnet

            List<string> SonnetLines = new List<string>();


            //for each sonnet in the list returned from the database, cycle through, split the lines up into individual arrays and add the lines to the list of sonnet lines
            foreach (var sonnet in sonnets)
            {
                var oneSonnetLinesArr = Regex.Split(sonnet.Lines, "@@");
                foreach (var line in oneSonnetLinesArr)
                {
                    SonnetLines.Add(line);
                }

            }

            //create a new instance of the random class
            Random random = new Random();
       
            //create a new array of strings to hold the user sonnet
            var UserSonnet = new string[14];
            //cycle through the list of sonnet lines and insert them at random into the user sonnet array

            for (int i = 0; i < 14; i++)
            {
                int r = random.Next(SonnetLines.Count());
                UserSonnet[i] = SonnetLines[r];
            }

            Poem mySonnet = new Poem();

            mySonnet.Title = "Your Computer Writes Better Poetry Than You Do";
            mySonnet.Author = userName;
            mySonnet.Lines = UserSonnet.ToString();
            mySonnet.FormId = 118;
            mySonnet.TopicId = 115;
            mySonnet.MoodId = 115;

            model.Poem = mySonnet;
            model.LinesArray = UserSonnet;

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> MyHaiku()
        {
            //create a new instance of the single poem view model to hold the generated poem
            //properties to include on single poem view model: 1.poem, 2. linesarray;

            SinglePoemViewModel model = new SinglePoemViewModel(context);
            var user = await GetCurrentUserAsync();
            var userName = user.UserName;

            //set some dummy properties on model.Poem so that View doesn't freak out

            //get all the sonnets back from the database
            var haikus = await context.Poem.Where(p => p.FormId == 120).ToListAsync();

            List<string> HaikuLines = new List<string>();


            //for each sonnet in the list returned from the database, cycle through, split the lines up into individual arrays
            foreach (var haiku in haikus)
            {
                var haikuLinesArray = Regex.Split(haiku.Lines, "@@");
                foreach (var line in haikuLinesArray)
                {
                    HaikuLines.Add(line);
                }

            }

            Random random = new Random();

            var userHaiku = new string[3];
            for (int i = 0; i < 3; i++)
            {
                int r = random.Next(HaikuLines.Count());
                userHaiku[i] = HaikuLines[r];
            }

            Poem myHaiku = new Poem();

            myHaiku.Title = "Your Computer Writes Better Poetry Than You Do";
            myHaiku.Author = userName;
            myHaiku.Lines = userHaiku.ToString();

            model.Poem = myHaiku;
            model.LinesArray = userHaiku;

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveUserSonnet(Poem poem)
        {

            context.Poem.Add(poem);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
