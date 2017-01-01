using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace The_Occasion.Models
{
    public class Author
    {
        [Key]

        public int AuthorId { get; set; }
        public string Name { get; set; }

        public string Bio { get; set; }
    }
}
