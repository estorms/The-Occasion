﻿using Microsoft.AspNetCore.Authorization;
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


namespace The_Occasion.Controllers
{
    [Authorize]
    public class PoemController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        public PoemController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
        {
            _userManager = user;
            context = ctx;
        }

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

        [HttpGet]
        public async Task<IActionResult>Bored()
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

        [HttpPost]
        public async Task<IActionResult> SaveBored([FromRoute] int id)
        {

            var user = await GetCurrentUserAsync();
            UserSelection userSelection = new UserSelection();
            userSelection.User = user;
            userSelection.PoemId = id;
            context.UserSelection.Add(userSelection);
            await context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");

        }
    }
}
