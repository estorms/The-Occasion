using System;
using System.Collections;
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
        public List <Poem>UserPoems { get; set; }

        public string FormName { get; set; }

        public string MoodName { get; set; }

        public string TopicName { get; set; }

    }
}
