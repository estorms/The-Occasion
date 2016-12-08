using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Occasion.Models
{
    public class Form
    {
        [Key]

        public int FormId { get; set; }

        public string FormName { get; set; }
    }
}
