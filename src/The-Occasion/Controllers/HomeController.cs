using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Occasion.Models.HomeViewModels;
using The_Occasion.Data;
using The_Occasion.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace The_Occasion.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        public HomeController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
        {
            _userManager = user;
            context = ctx;
        }
        public async Task <IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel(context);
            model.Form = await context.Form.ToListAsync();
            model.Mood = await context.Mood.ToListAsync();
            model.Topic = await context.Topic.ToListAsync();
            model.PickyForm = await context.Form.ToListAsync();
            model.PickyMood = await context.Mood.ToListAsync();
            model.PickyTopic = await context.Topic.ToListAsync();
            return View(model);

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
