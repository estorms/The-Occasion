using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The_Occasion.Models
{
    public class Poem
    {
        [Key]
        public int PoemId { get; set; }

        [Required]
        [Display(Name ="Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name ="Author")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Date Published")]
        public int PubDate { get; set; }

        [Display(Name ="Form")]
        public int FormId { get; set; }
        public Form Form { get; set; }

        [Display(Name = "Mood")]

        public int MoodId { get; set; }
        public Mood Mood { get; set; }

        [Display(Name = "Topic")]
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public string Lines { get; set; }

        public ICollection<UserSelection> UserSelections { get; set; }

        
    }
}
