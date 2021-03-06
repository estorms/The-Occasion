﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using The_Occasion.Models;

namespace The_Occasion.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Poem> Poem { get; set; }

        public DbSet<Form> Form { get; set; }

        public DbSet<Mood> Mood { get; set; }

        public DbSet<Topic> Topic { get; set; }

        public DbSet<Author> Author { get; set; }

        public DbSet<UserSelection> UserSelection { get; set;  }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
