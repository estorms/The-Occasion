using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;
using The_Occasion.Models;
using The_Occasion.Models.PoemViewModels;


namespace The_Occasion.Controllers
{
    [Authorize]
    public class PoemController: Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;

        private ApplicationDbContext context;

        public PoemController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
        {
            _userManager = user;
            context = ctx;
        }

        public async Task<IActionResult> Poem([FromRoute]int? id)
        {
            //throw a 404(NotFound) error if method is called w/o id in route
            if (id == null)
            {
                return NotFound();
            }

            // Create a new instance of the SinglePoemViewModel and pass it the existing BangazonContext (current db session) as an argument in order to extract the product whose id matches the argument passed in¸
            SinglePoemViewModel model = new SinglePoemViewModel(context);
            model.Poem = await context.Poem.SingleOrDefaultAsync(p => p.PoemId == id);

            // If no matching product found, return 404 error
            if (model.Poem == null)
            {
                return NotFound();
            }

            return View(model);
        }

    }
}
