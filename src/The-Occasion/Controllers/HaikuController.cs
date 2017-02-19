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


            SinglePoemViewModel model = new SinglePoemViewModel(context);
            var user = await GetCurrentUserAsync();
            var userName = user.UserName;
            var userFullName = user.FirstName + " " + user.LastName;


            //get all the sonnets back from the database
            var haikus = await context.Poem.Where(p => p.FormId == 120 && (p.Author == "Anselm Hollo" || p.Author == "Udiah (Witness to Yah)")).ToListAsync();

            List<string> HaikuLines = new List<string>();
            List<string> HaikuSecondLines = new List<string>();


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
                userHaiku[i] = HaikuLines[r];
            }


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

            myHaiku.Author = userFullName;
            myHaiku.Lines = stringbuilder.ToString();
            myHaiku.FormId = 120;
            myHaiku.MoodId = 115;
            myHaiku.TopicId = 115;
            model.Poem = myHaiku;

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SaveUserHaiku(Poem poem)
        {
            context.Poem.Add(poem);
            Author author = new Author();
            author.Name = poem.Author;
            await context.SaveChangesAsync();
            var user = await GetCurrentUserAsync();
            UserSelection userselection = new UserSelection();
            userselection.User = user;
            var newhaiku = await context.Poem.OrderByDescending(p => p.PoemId).FirstOrDefaultAsync();
            userselection.PoemId = newhaiku.PoemId;
            context.UserSelection.Add(userselection);
            await context.SaveChangesAsync();
            context.Author.Add(author);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}

