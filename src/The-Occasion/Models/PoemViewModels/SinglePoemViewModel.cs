using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Controllers;
using The_Occasion.Data;

namespace The_Occasion.Models.PoemViewModels
{
    public class SinglePoemViewModel
    {
       public Poem poem { get; set; }

        public SinglePoemViewModel(ApplicationDbContext ctx)
        {
            var context = ctx;
        }  
    }
}
