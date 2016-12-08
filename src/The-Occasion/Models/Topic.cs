using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace The_Occasion.Models
{
    public class Topic
    {

        [Key]

        public int TopicId { get; set; }

        public string TopicName { get; set; }
    }
}
