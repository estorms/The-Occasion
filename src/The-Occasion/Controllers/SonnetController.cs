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
using System.Text;

namespace TheOccasion_Controllers
{
    public class SonnetController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        public SonnetController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
        {
            _userManager = user;
            context = ctx;
        }


        [Authorize]
        private Task<ApplicationUser> GetCurrentUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
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
            var userFullName = user.FirstName + " " + user.LastName;

            //get all the sonnets back from the database
            var sonnets = await context.Poem.Where(p => p.FormId == 118).ToListAsync();

            //create a list of strings to hold all the individual lines of each sonnet

            List<string> SonnetLines = new List<string>();


            //for each sonnet in the list returned from the database, cycle through, split the lines up into individual arrays and add the lines to the list of sonnet lines
            foreach (var sonnet in sonnets)
            {
                if (sonnet.Lines == null)
                {
                    Console.WriteLine("Look at me");
                }
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

            StringBuilder stringbuilder = new StringBuilder();
            foreach (var line in UserSonnet)
            {
                stringbuilder.Append(line);
                stringbuilder.Append("@@");
            }

            Poem mySonnet = new Poem();

            mySonnet.Lines = stringbuilder.ToString();
            //mySonnet.Title = "Your Computer Writes Better Poetry Than You Do";
            mySonnet.Author = userFullName;
            //mySonnet.Lines = UserSonnet.ToString();
            mySonnet.FormId = 118;
            mySonnet.TopicId = 115;
            mySonnet.MoodId = 115;

            model.Poem = mySonnet;
            model.LinesArray = UserSonnet;

            return View(model);
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveUserSonnet(Poem poem)
        {
            context.Poem.Add(poem);
            await context.SaveChangesAsync();
            var user = await GetCurrentUserAsync();
            UserSelection userselection = new UserSelection();
            userselection.User = user;
            var newsonnet = await context.Poem.OrderByDescending(p => p.PoemId).FirstOrDefaultAsync();
            userselection.PoemId = newsonnet.PoemId;
            context.UserSelection.Add(userselection);
            await context.SaveChangesAsync();
            Author author = new Author();
            author.Name = poem.Author;
            context.Author.Add(author);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
