using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Occasion.Models
{
    public class UserSelection
    {
    [Key]

    public int UserSelectionId { get; set; }
    public virtual ApplicationUser User { get; set; }
    public int PoemId { get; set; }
    public Poem Poem { get; set; }
    }
}
