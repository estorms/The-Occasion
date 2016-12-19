using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Occasion.Data;

namespace The_Occasion.Models.PoemViewModels
{
    public class PickyPoemsViewModel
    {
        
            public IEnumerable<Form> Form { get; set; }
            public IEnumerable<Mood> Mood { get; set; }
            public IEnumerable<Topic> Topic { get; set; }
            public List<SelectListItem> FormId { get; set; }
            public List<SelectListItem> MoodId { get; set; }
            public List<SelectListItem> TopicId { get; set; }

            public PickyPoemsViewModel(ApplicationDbContext ctx)
            {


                this.FormId = ctx.Form
                                        .OrderBy(f => f.FormName)
                                        .AsEnumerable()
                                        .Select(li => new SelectListItem
                                        {
                                            Text = li.FormName,
                                            Value = li.FormId.ToString()
                                        }).ToList();
                this.FormId.Insert(0, new SelectListItem
                {
                    Text = "Choose A Form",
                    Value = "0"
                });

                this.MoodId = ctx.Mood
                                        .OrderBy(m => m.MoodName)
                                        .AsEnumerable()
                                        .Select(li => new SelectListItem
                                        {
                                            Text = li.MoodName,
                                            Value = li.MoodId.ToString()
                                        }).ToList();

                this.MoodId.Insert(0, new SelectListItem
                {
                    Text = "Choose A Mood",
                    Value = "0"
                });

                this.TopicId = ctx.Topic
                                        .OrderBy(t => t.TopicName)
                                        .AsEnumerable()
                                        .Select(li => new SelectListItem
                                        {
                                            Text = li.TopicName,
                                            Value = li.TopicId.ToString()
                                        }).ToList();
                this.TopicId.Insert(0, new SelectListItem
                {
                    Text = "Choose A Topic",
                    Value = "0"
                });
                
            }
        }
    }

