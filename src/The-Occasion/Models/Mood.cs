using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Occasion.Models
{
    public class Mood
    {
        [Key]
        public int MoodId { get; set; }

        public string MoodName { get; set; }
    }
}
