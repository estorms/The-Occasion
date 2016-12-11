using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;
using The_Occasion.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace The_Occasion.Models.HomeViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Form> Form { get; set; }
        public IEnumerable<Mood> Mood { get; set; }
        public IEnumerable<Topic> Topic { get; set; }
        public List<SelectListItem> FormId { get; set; }
        public List<SelectListItem> MoodId { get; set; }
        public List<SelectListItem> TopicId { get; set; }

        public HomeViewModel(ApplicationDbContext ctx)
        {


            this.FormId = ctx.Form
                                    .OrderBy(f => f.FormName)
                                    .AsEnumerable()
                                    .Select(li => new SelectListItem
                                    {
                                        Text = li.FormName,
                                        Value = li.FormId.ToString()
                                    }).ToList();


            this.MoodId = ctx.Mood
                                    .OrderBy(m => m.MoodName)
                                    .AsEnumerable()
                                    .Select(li => new SelectListItem
                                    {
                                        Text = li.MoodName,
                                        Value = li.MoodId.ToString()
                                    }).ToList();


            this.TopicId = ctx.Topic
                                    .OrderBy(t => t.TopicName)
                                    .AsEnumerable()
                                    .Select(li => new SelectListItem
                                    {
                                        Text = li.TopicName,
                                        Value = li.TopicId.ToString()
                                    }).ToList();
        }

    }
}
