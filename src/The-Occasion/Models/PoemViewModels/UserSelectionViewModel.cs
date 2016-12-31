using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;

namespace The_Occasion.Models.PoemViewModels
{
    public class UserSelectionViewModel
    {
        public UserSelectionViewModel(ApplicationDbContext ctx)
        {
            var context = ctx;
        }
        public List<Poem> UserPoems = new List<Poem>();

        public List<Poem> UserGeneratedHaikus = new List<Poem>();

        public List<Poem> UserGeneratedSonnets = new List<Poem>();

        public List<Poem> UserLikedPoems = new List<Poem>();
    }
}
