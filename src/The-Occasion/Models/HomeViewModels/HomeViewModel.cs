﻿using System;
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
        public IEnumerable<Form>PickyForm { get; set; }
        public IEnumerable<Mood>PickyMood { get; set; }
        public IEnumerable<Topic>PickyTopic { get; set; }
        public List<SelectListItem> FormId { get; set; }
        public List<SelectListItem> MoodId { get; set; }
        public List<SelectListItem> TopicId { get; set; }
        public List<SelectListItem> PickyFormId { get; set; }
        public List<SelectListItem>PickyMoodId { get; set; }
        public List<SelectListItem>PickyTopicId { get; set; }
        //public List<SelectListItem> AllQualifiers = new List<SelectListItem>();

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
            this.FormId.Insert(0, new SelectListItem
            {
                Text = "Browse By Form",
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
                Text = "Browse By Mood",
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
                Text = "Browse By Topic",
                Value = "0"
            });

            this.PickyFormId = ctx.Form
                                    .OrderBy(f => f.FormName)
                                    .AsEnumerable()
                                    .Select(li => new SelectListItem
                                    {
                                        Text = li.FormName,
                                        Value = li.FormId.ToString()
                                    }).ToList();
            this.PickyFormId.Insert(0, new SelectListItem
            {
                Text = "Your Picky Form",
                Value = "0"
            });

            this.PickyMoodId = ctx.Mood
                                    .OrderBy(m => m.MoodName)
                                    .AsEnumerable()
                                    .Select(li => new SelectListItem
                                    {
                                        Text = li.MoodName,
                                        Value = li.MoodId.ToString()
                                    }).ToList();

            this.PickyMoodId.Insert(0, new SelectListItem
            {
                Text = "Your Picky Mood",
                Value = "0"
            });

            this.PickyTopicId = ctx.Topic
                                    .OrderBy(t => t.TopicName)
                                    .AsEnumerable()
                                    .Select(li => new SelectListItem
                                    {
                                        Text = li.TopicName,
                                        Value = li.TopicId.ToString()
                                    }).ToList();
            this.PickyTopicId.Insert(0, new SelectListItem
            {
                Text = "Your Picky Topic",
                Value = "0"
            });

        }
        
    }
}
