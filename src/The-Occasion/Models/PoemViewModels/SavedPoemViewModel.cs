using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;

namespace The_Occasion.Models.PoemViewModels
{
    public class SavedPoemViewModel
    {

            public Poem Poem { get; set; }

            public Array LinesArray { get; set; }

            public List<Poem> OtherWorks = new List<Poem>();

            public UserSelection UserSelection { get; set; }

            public Author Author { get; set; }
            public string UserFullName { get; set; }
            public string Line1 { get; set; }
            public string Line2 { get; set; }
            public string Line3 { get; set; }


            public SavedPoemViewModel(ApplicationDbContext ctx)
            {
                var context = ctx;
            }
        }
    }

