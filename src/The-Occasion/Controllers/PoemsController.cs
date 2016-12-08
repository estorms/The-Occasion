using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;
using The_Occasion.Models;

namespace The_Occasion.Controllers
{
    [Authorize]
    public class PoemsController
    {
        
            private readonly UserManager<ApplicationUser> _userManager;

            private ApplicationDbContext context;

            public PoemsController(ApplicationDbContext ctx, UserManager<ApplicationUser> user)
            {
                _userManager = user;
                context = ctx;
            }
}
}
