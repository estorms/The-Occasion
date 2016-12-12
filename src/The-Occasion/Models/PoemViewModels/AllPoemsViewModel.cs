using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;

namespace The_Occasion.Models.PoemViewModels
{
    public class AllPoemsViewModel
    {
        public IEnumerable<Poem> AllPoems { get; set; }
        public AllPoemsViewModel(ApplicationDbContext ctx)
        {
            var context = ctx;
        }

        //public IEnumerable<Array>PoemLines { get; set; }
    }
}
