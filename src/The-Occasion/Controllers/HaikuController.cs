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
    public class HaikuController: Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        public HaikuController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
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
        public async Task<IActionResult> MyHaiku()
        {
            //create a new instance of the single poem view model to hold the generated poem
            //properties to include on single poem view model: 1.poem, 2. linesarray;

            SinglePoemViewModel model = new SinglePoemViewModel(context);
            var user = await GetCurrentUserAsync();
            var userName = user.UserName;

            //set some dummy properties on model.Poem so that View doesn't freak out

            //get all the sonnets back from the database
            var haikus = await context.Poem.Where(p => p.FormId == 120 && (p.Author == "Anselm Hollo" || p.Author == "Udiah (Witness to Yah)")).ToListAsync();

            List<string> HaikuLines = new List<string>();
            List<string> HaikuSecondLines = new List<string>();


            //for each sonnet in the list returned from the database, cycle through, split the lines up into individual arrays
            foreach (var haiku in haikus)
            {
                var haikuLinesArray = Regex.Split(haiku.Lines, "@@");
                for (int i = 0; i < haikuLinesArray.Length; i++)
                {
                    if (i == 1)
                    {
                        HaikuSecondLines.Add(haikuLinesArray[i]);
                    }
                    else
                    {
                        HaikuLines.Add(haikuLinesArray[i]);
                    }
                }

            }
            Random random = new Random();

            var userHaiku = new string[3];

            for (int i = 0; i < 3; i++)
            {
                int r = random.Next(HaikuLines.Count());
                //when trying to make userHaiku a list, instead of an array, throws index out of bounds exception right here.
                userHaiku[i] = HaikuLines[r];
            }

            //userHaiku = userHaiku.Where((source, index) => index != 1).ToArray();

            model.Line1 = userHaiku[0];
            model.Line3 = userHaiku[2];

            int r2 = random.Next(HaikuSecondLines.Count());
            model.Line2 = HaikuSecondLines[r2];

            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append(userHaiku[0]);
            stringbuilder.Append("@@");
            stringbuilder.Append(HaikuSecondLines[r2]);
            stringbuilder.Append("@@");
            stringbuilder.Append(userHaiku[2]);



            Poem myHaiku = new Poem();

            //myHaiku.Title = "Your Computer Writes Better Poetry Than You Do";
            myHaiku.Author = userName;
            //need to convert the below to string with stringbuilder as in sonnet and make other changes to razor to allow saving
            myHaiku.Lines = stringbuilder.ToString();
            myHaiku.FormId = 120;
            myHaiku.MoodId = 115;
            myHaiku.TopicId = 115;
            model.Poem = myHaiku;
            //model.LinesArray = userHaiku;

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveUserHaiku(Poem poem)
        {
            context.Poem.Add(poem);
            await context.SaveChangesAsync();
            var user = await GetCurrentUserAsync();
            UserSelection userselection = new UserSelection();
            userselection.User = user;
            var newhaiku = await context.Poem.OrderByDescending(p => p.PoemId).FirstOrDefaultAsync();
            userselection.PoemId = newhaiku.PoemId;
            context.UserSelection.Add(userselection);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

