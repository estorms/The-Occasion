using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using The_Occasion.Data;
using The_Occasion.Models.PoemViewModels;

namespace The_Occasion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();

            Console.WriteLine("jessup rides");
            ApplicationDbContext applicationDbContext = new ApplicationDbContext();
            var AllPoems = applicationDbContext.Poem;
            Console.Write(AllPoems);
        }
    }
}
