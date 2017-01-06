using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using The_Occasion.Data;
using The_Occasion.Models;
using The_Occasion.Models.PoemViewModels;
using The_Occasion.ExtensionMethods;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.Serialization.Formatters;
using System.IO;


namespace The_Occasion.Controllers
{
    public class PoemController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        private bool _authorExists(string name)
        {
            return context.Author.Count(a => a.Name == name) > 0;
        }



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

        public IActionResult Picky()
        {
            PickyPoemsViewModel model = new PickyPoemsViewModel(context);
            return View(model);
        }

        [Authorize]
        [HttpGet("/Poem/Curate/{moodId}/{topicId}/{formId}")]

        public async Task<IActionResult> Curate([FromRoute]int moodId, [FromRoute]int topicId, [FromRoute]int formId)
        {
            var curatedPoems = await context.Poem.Where(p => p.MoodId == moodId && p.TopicId == topicId && p.FormId == formId).ToListAsync();
            AllPoemsViewModel model = new AllPoemsViewModel(context);
            model.AllPoems = curatedPoems;
            return View(model);

        }

        [Authorize]
        public async Task<IActionResult> MyPoems()
        {
            UserSelectionViewModel model = new UserSelectionViewModel(context);
            //identify the current user, which will be coerced to the userId
            var user = await GetCurrentUserAsync();
            //identify all of the user selections by the user Id
            var userName = user.UserName;
            var userFullName = user.FirstName + " " + user.LastName;
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

            foreach (var poem in model.UserPoems)
            {
                if (poem.Author == userFullName && poem.FormId == 120)
                {
                    model.UserGeneratedHaikus.Add(poem);
                }

                else if (poem.Author == userFullName && poem.FormId == 118)
                {
                    model.UserGeneratedSonnets.Add(poem);
                }

                else
                {
                    model.UserLikedPoems.Add(poem);
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

            if (id == null)
            {
                return NotFound();
            }

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
            var user = await GetCurrentUserAsync();
            var userFullName = user.FirstName + " " + user.LastName;
            model.UserFullName = userFullName;

            if (_authorExists(SinglePoem.Author))
            {
                Author poemAuthor = await context.Author.Where(a => a.Name == SinglePoem.Author).FirstAsync();
                model.Author = poemAuthor;
            }

            else
            {
                model.Author = null;
            };

            //List<Poem> Excess = new List<Poem>();

            //below simply matches poems from the poem table to authors from the author table...it's practice in using join/in/on/equals/select syntax, but there's a more efficient method available. Right here you're deliberately choosing excess logic for the exercise. You do this more readily by querying the poem table in the database by the name of the author already established above

            //var collectedworks = await (from poem in context.Poem join author in context.Author on poem.Author equals author.Name select poem).ToListAsync();

            var OtherWorks = await context.Poem.Where(p => p.Author == model.Poem.Author && p.Title != model.Poem.Title).ToListAsync();
            var OtherWorksUniqueTitles = OtherWorks.DistinctBy(w => w.Title).OrderBy(w => w.Title).ToList();
            model.OtherWorks = OtherWorksUniqueTitles;
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
            var user = await GetCurrentUserAsync();
            var userFullName = user.FirstName + " " + user.LastName;
            Author author = new Author();
            author = await context.Author.Where(a => a.Name == SinglePoem.Author).FirstOrDefaultAsync();
            model.Author = author;
            model.UserFullName = userFullName;

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
        [HttpPost]

        public async Task<IActionResult> UpdatePoem([FromBody] Poem poem)
        {

            
            var poemToUpdate = await context.Poem.Where(p => p.PoemId == poem.PoemId).SingleOrDefaultAsync();
            poemToUpdate.Author = poem.Author;
            poemToUpdate.Title = poem.Title;
            poemToUpdate.Lines = poem.Lines;
            context.Poem.Update(poemToUpdate);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
