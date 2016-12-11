using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;
using The_Occasion.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace The_Occasion.Models.HomeViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Form>Forms { get; set; }
        public IEnumerable<Mood>Moods { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
        public HomeViewModel(ApplicationDbContext ctx) { }

    }
}
