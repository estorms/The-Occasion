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
                Title="Still I Rise",
                Author="Maya Angelou",
                FormId = 117,
                MoodId = 113,
                TopicId=115,
                Lines="@@You may write me down in history@@With your bitter, twisted lies,@@You may trod me in the very dirt@@But still, like dust, I’ll rise.@@@@Does my sassiness upset you?@@Why are you beset with gloom?@@‘Cause I walk like I’ve got oil wells@@Pumping in my living room.@@@@Just like moons and like suns,@@With the certainty of tides,@@Just like hopes springing high,@@Still I’ll rise.@@@@Did you want to see me broken?@@Bowed head and lowered eyes?@@Shoulders falling down like teardrops,@@Weakened by my soulful cries?@@@@Does my haughtiness offend you?@@Don’t you take it awful hard@@‘Cause I laugh like I’ve got gold mines@@Diggin’ in my own backyard.@@@@You may shoot me with your words,@@You may cut me with your eyes,@@You may kill me with your hatefulness,@@But still, like air, I’ll rise.@@@@Does my sexiness upset you?@@Does it come as a surprise@@That I dance like I’ve got diamonds@@At the meeting of my thighs?@@@@Out of the huts of history’s shame@@I rise@@Up from a past that’s rooted in pain@@I rise@@I’m a black ocean, leaping and wide,@@Welling and swelling I bear in the tide.@@@@Leaving behind nights of terror and fear@@I rise@@Into a daybreak that’s wondrously clear@@I rise@@Bringing the gifts that my ancestors gave,@@I am the dream and the hope of the slave.@@I rise@@I rise@@I rise.@@@@"
            },

            new Poem
            {
                Title="Acquainted With the Night",
                Author="Robert Frost",
                FormId = 117,
                MoodId=116,
                TopicId=115,
                Lines="I have been one acquainted with the night.@@I have walked out in rain—and back in rain.@@I have outwalked the furthest city light.@@@@I have looked down the saddest city lane.@@I have passed by the watchman on his beat@@And dropped my eyes, unwilling to explain.@@@@I have stood still and stopped the sound of feet@@When far away an interrupted cry@@Came over houses from another street,@@@@But not to call me back or say good-bye;@@And further still at an unearthly height,@@One luminary clock against the sky@@@@Proclaimed the time was neither wrong nor right.@@I have been one acquainted with the night.@@"
            },

            new Poem
            {
                Title="An Electric Sign Goes Dark",
                Author="Carl Sandburg",
                FormId = 117,
                MoodId=116,
                TopicId=116,
                Lines="Poland, France, Judea ran in her veins,@@Singing to Paris for bread, singing to Gotham in a fizz at the pop of a bottle’s cork.@@@@“Won’t you come and play wiz me” she sang … and “I just can’t make my eyes behave.”@@“Higgeldy-Piggeldy,” “Papa’s Wife,” “Follow Me” were plays.@@@@Did she wash her feet in a tub of milk? Was a strand of pearls sneaked from her trunk? The newspapers asked.@@Cigarettes, tulips, pacing horses, took her name.@@@@Twenty years old … thirty … forty …@@Forty-five and the doctors fathom nothing, the doctors quarrel, the doctors use silver tubes feeding twenty-four quarts of blood into the veins, the respects of a prize-fighter, a cab driver.@@And a little mouth moans: It is easy to die when they are dying so many grand deaths in France.@@@@A voice, a shape, gone.@@A baby bundle from Warsaw … legs, torso, head … on a hotel bed at The Savoy.@@The white chiselings of flesh that flung themselves in somersaults, straddles, for packed houses:@@A memory, a stage and footlights out, an electric sign on Broadway dark.@@@@She belonged to somebody, nobody.@@No one man owned her, no ten nor a thousand.@@She belonged to many thousand men, lovers of the white chiseling of arms and shoulders, the ivory of a laugh, the bells of song.@@@@Railroad brakemen taking trains across Nebraska prairies, lumbermen jaunting in pine and tamarack of the Northwest, stock ranchers in the middle west, mayors of southern cities@@Say to their pals and wives now: I see by the papers Anna Held is dead.@@@@--Carl Sandburg@@"
            },

            //new Poem
            //{
            //    Title="Sonnet (Death, Be Ye Not Proud)",
            //    Author="John Donne",
            //    FormId=118,
            //    MoodId=113,
            //    TopicId=113,
            //    Lines="Death, be not proud, though some have called thee@@Mighty and dreadful, for thou are not so;@@For those whom thou think’st thou dost overthrow@@Die not, poor Death, nor yet canst thou kill me.@@From rest and sleep, which but thy pictures be,@@Much pleasure; then from thee much more must flow,@@And soonest our best men with thee do go,@@Rest of their bones, and soul’s delivery.@@Thou’art slave to fate, chance, kings, and desperate men,@@And dost with poison, war, and sickness dwell,@@And poppy’or charms can make us sleep as well@@And better than thy stroke; why swell’st thou then?@@One short sleep past, we wake eternally,@@And death shall be no more; Death, thou shalt die.@@@@"
            //},

            //new Poem
            //{
            //    Title="Sonnet 53",
            //    Author="William Shakespeare",
            //    FormId=118,
            //    MoodId=113,
            //    TopicId=115,
            //    Lines="What is your substance, whereof are you made,@@That millions of strange shadows on you tend?@@Since every one hath, every one, one shade,@@And you, but one, can every shadow lend.@@Describe Adonis, and the counterfeit@@Is poorly imitated after you;@@On Helen's cheek all art of beauty set,@@And you in Grecian tires are painted new.@@Speak of the spring and foison of the year:@@The one doth shadow of your beauty show,@@The other as your bounty doth appear;@@And you in every blessèd shape we know.@@    In all external grace you have some part,@@    But you like none, none you, for constant heart.@@@@"
            //},

            new Poem
            {
                Title="The Genius of the Crowd",
                Author="Charles Bukowski",
                FormId = 117,
                MoodId=116,
                TopicId=115,
                Lines="there is enough treachery, hatred violence absurdity in the average@@human being to supply any given army on any given day@@@@and the best at murder are those who preach against it@@and the best at hate are those who preach love@@and the best at war finally are those who preach peace@@@@those who preach god, need god@@those who preach peace do not have peace@@those who preach peace do not have love@@@@beware the preachers@@beware the knowers@@beware those who are always reading books@@beware those who either detest poverty@@or are proud of it@@beware those quick to praise@@for they need praise in return@@beware those who are quick to censor@@they are afraid of what they do not know@@beware those who seek constant crowds for@@they are nothing alone@@beware the average man the average woman@@beware their love, their love is average@@seeks average@@@@but there is genius in their hatred@@there is enough genius in their hatred to kill you@@to kill anybody@@not wanting solitude@@not understanding solitude@@they will attempt to destroy anything@@that differs from their own@@not being able to create art@@they will not understand art@@they will consider their failure as creators@@only as a failure of the world@@not being able to love fully@@they will believe your love incomplete@@and then they will hate you@@and their hatred will be perfect@@@@like a shining diamond@@like a knife@@like a mountain@@like a tiger@@like hemlock@@@@their finest art"
            }

          
        };
            public Array GetPoems () {
            return PoemsArr;
            }
        };
    }
