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
            //    new Poem
            //    {
            //        Title="Don't Let That Horse",
            //        Author="Lawrence Ferlinghetti",
            //        MoodId=114,
            //        FormId=117,
            //        TopicId=115,
            //        Lines="Don’t let that horse @@eat that violin @@@@cried Chagall’s mother @@@@But he @@kept right on @@painting @@@@And became famous @@@@And kept on painting @@The Horse With Violin In Mouth @@@@And when he finally finished it @@he jumped up upon the horse @@and rode away @@waving the violin @@@@And then with a low bow gave it @@to the first naked nude he ran across @@@@And there were no strings @@attached"
            //    },

            //    new Poem
            //    {
            //        Title="Lies",
            //        Author="Yevgeny Yevtushenko",
            //        MoodId=116,
            //        FormId=117,
            //        TopicId=115,
            //        Lines="@@Telling lies to the young is wrong.@@Proving to them that lies are true is wrong.@@Telling them that God’s in his heaven@@and all’s well with the world is wrong.@@The young know what you mean.  The young are@@people.@@Tell them the difficulties can’t be counted,@@and let them see not only what will be@@but see with clarity these present times.@@Say obstacles exist they must encounter@@sorrow happens, hardship happens.@@The hell with it.  Who never knew@@the price of happiness will not be happy.@@Forgive no error you recognize,@@it will repeat itself, increase,@@and afterwards our pupils@@will not forgive us what we forgave."
            //    },

            //    new Poem
            //    {
            //        Title="here yet be dragons",
            //        Author="Lucille Clifton",
            //        MoodId=115,
            //        FormId=117,
            //        TopicId=115,
            //        Lines="so many languages have fallen@@off of the edge of the world@@into the dragon’s mouth.  some@@@@where there be monsters whose teeth@@are sharp and sparkle with lost@@@@people.  lost poems.  who@@among us can imagine ourselves@@unimagined?  who@@@@among us can speak with so fragile@@tongue and remain proud?"
            //    },

            //    new Poem
            //    {
            //        Title="Those Winter Sundays",
            //        Author="Robert E. Hayden",
            //        MoodId=113,
            //        TopicId=114,
            //        FormId=117,
            //        Lines="@@Sundays too my father got up early @@and put his clothes on in the blueblack cold, @@then with cracked hands that ached @@from labor in the weekday weather made @@banked fires blaze. No one ever thanked him. @@@@I’d wake and hear the cold splintering, breaking. @@When the rooms were warm, he’d call, @@and slowly I would rise and dress, @@fearing the chronic angers of that house, @@@@Speaking indifferently to him, @@who had driven out the cold @@and polished my good shoes as well. @@What did I know, what did I know @@of love’s austere and lonely offices?"
            //    },

            //    new Poem
            //    {
            //        Title="Bread and Music",
            //        Author="Conrad Aiken",
            //        FormId=118,
            //        MoodId=116,
            //        TopicId=113,
            //        Lines="@@@@Music I heard with you was more than music,@@And bread I broke with you was more than bread;@@Now that I am without you, all is desolate;@@All that was once so beautiful is dead.@@@@Your hands once touched this table and this silver,@@And I have seen your fingers hold this glass.@@These things do not remember you, belovèd,@@And yet your touch upon them will not pass.@@@@For it was in my heart you moved among them,@@And blessed them with your hands and with your eyes;@@And in my heart they will remember always,—@@They knew you once, O beautiful and wise.@@@@"
            //    },

            //      new Poem
            //    {
            //        Title="Bread and Music",
            //        Author="Conrad Aiken",
            //        FormId=118,
            //        MoodId=116,
            //        TopicId=114,
            //        Lines="@@@@Music I heard with you was more than music,@@And bread I broke with you was more than bread;@@Now that I am without you, all is desolate;@@All that was once so beautiful is dead.@@@@Your hands once touched this table and this silver,@@And I have seen your fingers hold this glass.@@These things do not remember you, belovèd,@@And yet your touch upon them will not pass.@@@@For it was in my heart you moved among them,@@And blessed them with your hands and with your eyes;@@And in my heart they will remember always,—@@They knew you once, O beautiful and wise.@@@@"
            //    },

            //      new Poem
            //      {
            //          Title="Leda and the Swan",
            //          Author="William Butler Yeats",
            //          FormId = 118,
            //          TopicId=115,
            //          MoodId=115,
            //          Lines="A sudden blow: the great wings beating still@@Above the staggering girl, her thighs caressed@@By the dark webs, her nape caught in his bill,@@He holds her helpless breast upon his breast.@@@@How can those terrified vague fingers push@@The feathered glory from her loosening thighs?@@And how can body, laid in that white rush,@@But feel the strange heart beating where it lies?@@@@A shudder in the loins engenders there@@The broken wall, the burning roof and tower@@And Agamemnon dead.@@                                            Being so caught up,@@So mastered by the brute blood of the air,@@Did she put on his knowledge with his power@@Before the indifferent beak could let her drop?"
            //      },
            //          new Poem
            //      {
            //          Title="Leda and the Swan",
            //          Author="William Butler Yeats",
            //          FormId = 118,
            //          TopicId=116,
            //          MoodId=115,
            //          Lines="A sudden blow: the great wings beating still@@Above the staggering girl, her thighs caressed@@By the dark webs, her nape caught in his bill,@@He holds her helpless breast upon his breast.@@@@How can those terrified vague fingers push@@The feathered glory from her loosening thighs?@@And how can body, laid in that white rush,@@But feel the strange heart beating where it lies?@@@@A shudder in the loins engenders there@@The broken wall, the burning roof and tower@@And Agamemnon dead.@@                                            Being so caught up,@@So mastered by the brute blood of the air,@@Did she put on his knowledge with his power@@Before the indifferent beak could let her drop?"
            //      }

            //};
            new Poem
            {
                Title="Sonnet (Death, Be Ye Not Proud)",
                Author="John Donne",
                FormId=118,
                MoodId=113,
                TopicId=113,
                Lines="Death, be not proud, though some have called thee@@Mighty and dreadful, for thou are not so;@@For those whom thou think’st thou dost overthrow@@Die not, poor Death, nor yet canst thou kill me.@@From rest and sleep, which but thy pictures be,@@Much pleasure; then from thee much more must flow,@@And soonest our best men with thee do go,@@Rest of their bones, and soul’s delivery.@@Thou’art slave to fate, chance, kings, and desperate men,@@And dost with poison, war, and sickness dwell,@@And poppy’or charms can make us sleep as well@@And better than thy stroke; why swell’st thou then?@@One short sleep past, we wake eternally,@@And death shall be no more; Death, thou shalt die.@@@@"
            },

            new Poem
            {
                Title="Sonnet 53",
                Author="William Shakespeare",
                FormId=118,
                MoodId=113,
                TopicId=115,
                Lines="What is your substance, whereof are you made,@@That millions of strange shadows on you tend?@@Since every one hath, every one, one shade,@@And you, but one, can every shadow lend.@@Describe Adonis, and the counterfeit@@Is poorly imitated after you;@@On Helen's cheek all art of beauty set,@@And you in Grecian tires are painted new.@@Speak of the spring and foison of the year:@@The one doth shadow of your beauty show,@@The other as your bounty doth appear;@@And you in every blessèd shape we know.@@    In all external grace you have some part,@@    But you like none, none you, for constant heart.@@@@"
            },

          
        };
            public Array GetPoems () {
            return PoemsArr;
            }
        };
    }
