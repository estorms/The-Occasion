using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace The_Occasion.Models
{
    public class BigOleListOfPoems
    {
        public Array PoemsArr = new Poem[] {
            new Poem
            {
                Author="Fletcher Bangs Watson VI",
                Title="Untitled",
                FormId = 120,
                MoodId = 114,
                TopicId = 115,
                Lines="Beautifully removed:@@the cricket and the oak tree@@relax without me"
            },

             new Poem
             {
                 Author="William Wordsworth",
                 Title="London, 1802",
                 Lines="Milton! thou shouldst be living at this hour:@@England hath need of thee: she is a fen@@Of stagnant waters: altar, sword, and pen,@@Fireside, the heroic wealth of hall and bower,@@Have forfeited their ancient English dower@@Of inward happiness. We are selfish men;@@Oh! raise us up, return to us again;@@And give us manners, virtue, freedom, power.@@Thy soul was like a Star, and dwelt apart;@@Thou hadst a voice whose sound was like the sea:@@Pure as the naked heavens, majestic, free,@@So didst thou travel on life's common way,@@In cheerful godliness; and yet thy heart@@The lowliest duties on herself did lay.",
                 FormId=118,
                 MoodId=113,
                 TopicId=114,
                
             },

             new Poem
             {
                 Author="Charles Tennyson",
                 Title="Missing the Meteors",
                 Lines="A hint of rain--a touch of lazy doubt--@@Sent me to bedward on that prime of nights,@@When the air met and burst the aerolites,@@Making the men stare and the children shout:@@Why did no beam from all that rout and rush@@Of darting meteors, pierce my drowsed head?@@Strike on the portals of my sleep? and flush@@My spirit through mine eyelids, in the stead@@Of that poor vapid dream? My soul was pained,@@My very soul, to have slept while others woke,@@While little children their delight outspoke,@@And in their eyes' small chambers entertained@@Far notions of the Kosmos! I mistook@@The purpose of that night--it had not rained.",
                 FormId = 118,
                 MoodId=113,
                 TopicId=115
             }
            };
            public Array GetPoems () {
            return PoemsArr;
            }
        };
    }
