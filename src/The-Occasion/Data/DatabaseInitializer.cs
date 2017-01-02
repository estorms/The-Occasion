using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using The_Occasion.Models;

namespace The_Occasion.Data
{

    public class DatabaseInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {


                BigOleListOfPoems bigolelist = new BigOleListOfPoems();
                var poems = bigolelist.GetPoems();
                foreach(Poem poem in poems)
                {
                    context.Poem.Add(poem);
                }
                context.SaveChanges();
                    }
                }
            }
        }
    

        
                
