using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using The_Occasion.Models;

namespace The_Occasion.Data
{
    public class DatabaseInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any forms.
                if (context.Poem.Count() > 1 )
                {
                    return;
                }

                var poems = new Poem[]
                   {
                     new Poem {
                         Title = "13 Ways of Looking at a Blackbird",
                         Author = "Wallace Stevens",
                         Collection = "Harmonium",
                         PubDate = 1954,
                         MoodId = 3,
                         FormId = 1,
                         TopicId = 4,
                         Lines = "I Among twenty snowy mountains, The only moving thing Was the eye of the blackbird. II I was of three minds, Like a tree In which there are three blackbirds. III The blackbird whirled in the autumn winds. It was a small part of the pantomime. IV A man and a woman Are one. A man and a woman and a blackbird Are one. V I do not know which to prefer, The beauty of inflections Or the beauty of innuendoes, The blackbird whistling Or just after. VI Icicles filled the long window With barbaric glass. The shadow of the blackbird Crossed it, to and fro. The mood Traced in the shadow An indecipherable cause. VII O thin men of Haddam, Why do you imagine golden birds? Do you not see how the blackbird Walks around the feet Of the women about you? VIII I know noble accents And lucid, inescapable rhythms; But I know, too, That the blackbird is involved In what I know. IX When the blackbird flew out of sight, It marked the edge Of one of many circles. X At the sight of blackbirds Flying in a green light, Even the bawds of euphony Would cry out sharply. XI He rode over Connecticut In a glass coach. Once, a fear pierced him, In that he mistook The shadow of his equipage For blackbirds. XII The river is moving. The blackbird must be flying. XIII It was evening all afternoon. It was snowing And it was going to snow. The blackbird sat In the cedar-limbs."
                     }
                   }; 
                   
                var forms = new Form[] {

                    new Form
                    {
                        FormName = "Free Verse"
                    },

                    new Form
                    {
                        FormName = "Sonnet"
                    },
                    new Form
                    {
                         FormName = "Ghazal"
                    },

                    new Form
                    {
                        FormName = "Haiku"
                    }

                    };

                foreach (Form f in forms)
                {
                    context.Form.Add(f);
                };


                var moods = new Mood[]
                {
                    new Mood
                    {
                        MoodName = "Sentiment, Please"
                    },

                    new Mood
                    {
                        MoodName = "Whimsy"
                    },

                    new Mood
                    {
                        MoodName = "Arcana"
                    },


                    new Mood {
                        MoodName ="It Rains"
                    }

                    };

                var topics = new Topic[] {

                    new Topic
                    {
                        TopicName = "Demise"
                    },

                    new Topic
                    {
                        TopicName = "Matters of the Heart"
                    },

                    new Topic
                    {
                        TopicName = "Sartrean, or Just Confused"
                    },

                    new Topic
                    {
                        TopicName= "Blackbirds"
                    }
                };

                foreach (Topic t in topics)
                {
                    context.Topic.Add(t);
                }

                foreach (Poem p in poems)
                {
                    context.Poem.Add(p);
                } 


                foreach (Mood m in moods)
                {
                    context.Mood.Add(m);
                }
                context.SaveChanges();


            }
        }
    }
}

