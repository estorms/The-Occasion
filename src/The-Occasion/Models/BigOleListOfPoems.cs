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

            //new Poem
            //{
            //    Title="Haiku Ambulance",
            //    Author="Richard Brautigan",
            //    MoodId=114,
            //    TopicId = 115,
            //    FormId = 120,
            //    Lines="A piece of green pepper @@Fell off the wooden salad @@Bowl: so what?"
            //}

            //new Poem
            //{
            //    Title="The New Colossus",
            //    Author="Emma Lazarus",
            //    FormId = 118,
            //    MoodId = 113,
            //    TopicId = 115,
            //    Lines = "Not like the brazen giant of Greek fame,@@With conquering limbs astride from land to land;@@Here at our sea-washed, sunset gates shall stand@@A mighty woman with a torch, whose flame@@Is the imprisoned lightning, and her name@@Mother of Exiles. From her beacon-hand@@Glows world-wide welcome; her mild eyes command@@The air-bridged harbor that twin cities frame.@@'Keep, ancient lands, your storied pomp!' cries she@@With silent lips. 'Give me your tired, your poor,@@Your huddled masses yearning to breathe free,@@The wretched refuse of your teeming shore.@@Send these, the homeless, tempest-tost to me,@@I lift my lamp beside the golden door!' "
            //},

            //new Poem
            //{
            //    Title="My Letters! all dead paper (Sonnet 28)",
            //    Author="Elizabeth Barrett Browning",
            //    FormId = 118,
            //    MoodId = 113,
            //    TopicId = 116,
            //    Lines="My letters! all dead paper, mute and white!@@And yet they seem alive and quivering@@Against my tremulous hands which loose the string@@And let them drop down on my knee tonight.@@This said—he wished to have me in his sight@@Once, as a friend: this fixed a day in spring@@To come and touch my hand. . . a simple thing,@@Yes I wept for it—this . . . the paper’s light. . .@@Said, Dear, I love thee; and I sank and quailed@@As if God’s future thundered on my past.@@This said, I am thine—and so its ink has paled@@With lying at my heart that beat too fast.@@And this . . . 0 Love, thy words have ill availed@@If, what this said, I dared repeat at last!"
            //},

            //new Poem
            //{
            //    Author="Rainer Maria Rilke",
            //    Title="Sonnet 6",
            //    FormId=118,
            //    MoodId=115,
            //    TopicId=115,
            //    Lines="Is he native to this realm? No,@@his wide nature grew out of both worlds.@@They more adeptly bend the willow’s branches@@who have experience of the willow’s roots.@@@@When you go to bed, don’t leave bread or milk@@on the table: it attracts the dead—@@But may he, this quiet conjurer, may he@@beneath the mildness of the eyelid@@@@mix their bright traces into every seen thing;@@and may the magic of earthsmoke and rue@@be as real for him as the clearest connection.@@@@Nothing can mar for him the authentic image;@@whether he wanders through houses or graves,@@let him praise signet ring, gold necklace, jar."
            //},

            //new Poem
            //{
            //    Title="I Shall Forget You Presently",
            //    Author="Edna St. Vincent Millay",
            //    MoodId=116,
            //    TopicId = 114,
            //    FormId=118,
            ////    Lines="I shall forget you presently, my dear,@@So make the most of this, your little day,@@Your little month, your little half a year@@Ere I forget, or die, or move away,@@And we are done forever; by and by@@I shall forget you, as I said, but now,@@If you entreat me with your loveliest lie@@I will protest you with my favorite vow.@@I would indeed that love were longer-lived,@@And vows were not so brittle as they are,@@But so it is, and nature has contrived@@To struggle on without a break thus far,—@@Whether or not we find what we are seeking@@Is idle, biologically speaking."

            ////},

            ////new Poem
            ////{
            ////    Title="Sunset",
            ////    Author="e.e. cummings",
            ////    FormId = 118,
            ////    MoodId = 113,
            ////    TopicId = 115,
            ////    Lines="Great carnal mountains crouching in the cloud@@That marrieth the young earth with a ring,@@Yet still its thoughts builds heavenward, whence spring@@Wee villages of vapor, sunset-proud.—@@And to the meanest door hastes one pure-browed@@White-fingered star, a little, childish thing,@@The busy needle of her light to bring,@@And stitch, and stitch, upon the dead day’s shroud.@@Poises the sun upon his west, a spark@@Superlative,—and dives beneath the world;@@From the day’s fillets Night shakes out her locks;@@List! One pure trembling drop of cadence purled—@@“Summer!”—a meek thrush whispers to the dark.@@Hark! the cold ripple sneering on the rocks!"

            ////},

            ////new Poem
            ////{
            ////    Title="Sonnet",
            ////    Author="Alice Dunbar-Nelson",
            ////    FormId=118,
            ////    TopicId=114,
            ////    MoodId=113,
            ////    Lines="I had no thought of violets of late,      @@The wild, shy kind that spring beneath your feet@@In wistful April days, when lovers mate@@And wander through the fields in raptures sweet.@@The thought of violets meant florists’ shops,@@And bows and pins, and perfumed papers fine;@@And garish lights, and mincing little fops@@And cabarets and songs, and deadening wine. @@So far from sweet real things my thoughts had strayed, @@I had forgot wide fields, and clear brown streams;            @@The perfect loveliness that God has made,— @@Wild violets shy and Heaven-mounting dreams.@@And now—unwittingly, you’ve made me dream@@Of violets, and my soul’s forgotten gleam.    "
            ////}
            

            //new Poem
            //{
            //Title="13 Ways of Looking at a Blackbird (I)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="Among twenty snowy mountains,@@The only moving thing@@Was the eye of the blackbird."


            //},

            // new Poem {
            //Title="13 Ways of Looking at a Blackbird (II)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="I was of three minds,@@Like a tree@@In which there are three blackbirds."


            //},

            //new Poem    {
            //Title="13 Ways of Looking at a Blackbird (III)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="The blackbird whirled in the autumn winds.@@It was a small part of the pantomime."


            //},


            // new Poem {
            //Title="13 Ways of Looking at a Blackbird (IV)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="A man and a woman@@Are one.@@A man and a woman and a blackbird@@Are one."


            //},


            // new Poem {
            //Title="13 Ways of Looking at a Blackbird (V)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="I do not know which to prefer,@@The beauty of inflections@@Or the beauty of innuendoes,@@The blackbird whistling@@Or just after."


            //},


            // new Poem {
            //Title="13 Ways of Looking at a Blackbird (VI)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="Icicles filled the long window@@With barbaric glass.@@The shadow of the blackbird@@Crossed it, to and fro.@@The mood@@Traced in the shadow@@An indecipherable cause."


            //},
            //   new Poem {
            //Title="13 Ways of Looking at a Blackbird (VII)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="O thin men of Haddam,@@Why do you imagine golden birds?@@Do you not see how the blackbird@@Walks around the feet@@Of the women about you?"


            //},
            //     new Poem {
            //Title="13 Ways of Looking at a Blackbird (VIII)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="I know noble accents@@And lucid, inescapable rhythms;@@But I know, too,@@That the blackbird is involved@@In what I know."


            //},
            //       new Poem {
            //Title="13 Ways of Looking at a Blackbird (IX)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="When the blackbird flew out of sight,@@It marked the edge@@Of one of many circles."


            //},
            //         new Poem {
            //Title="13 Ways of Looking at a Blackbird (XIII)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="It was evening all afternoon.@@It was snowing@@And it was going to snow.@@The blackbird sat@@In the cedar-limbs."


            //},
            //           new Poem {
            //Title="13 Ways of Looking at a Blackbird (XI)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="He rode over Connecticut@@In a glass coach.@@Once, a fear pierced him,@@In that he mistook@@The shadow of his equipage@@For blackbirds."


            //},
            //             new Poem {
            //Title="13 Ways of Looking at a Blackbird (XII)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="The river is moving.@@The blackbird must be flying."


            //},
            //               new Poem {
            //Title="13 Ways of Looking at a Blackbird (X)",
            //Author="Wallace Stevens",
            //FormId = 120,
            //MoodId = 115,
            //TopicId = 116,
            //Lines="At the sight of blackbirds@@Flying in a green light,@@Even the bawds of euphony@@Would cry out sharply."


            //},

            //new Poem
            //{
            //    Title="Haiku (Clever)",
            //    Author="Thomas Shavor",
            //    FormId = 120,
            //    MoodId = 114,
            //    TopicId= 115,
            //    Lines="You have just started@@reading the clever haiku@@that you just finished!"
            //},

            //new Poem
            //{
            //    Title = "In a Station of the Metro",
            //    Author="Ezra Pound",
            //    FormId = 120,
            //    MoodId = 115,
            //    TopicId = 115,
            //    Lines="The apparition of these faces in the crowd;@@Petals on a wet, black bough."
            //},

            //new Poem
            //{
            //    Title="5 & 7 & 5 (Excerpt I)",
            //    Author="Anselm Hollo",
            //    FormId = 120,
            //    MoodId = 115,
            //    TopicId = 115,
            //    Lines= "wind rain you and me@@went looking for a new house@@o the grass grows loud"
            //},

            //   new Poem
            //{
            //    Title="5 & 7 & 5 (Excerpt II)",
            //    Author="Anselm Hollo",
            //    FormId = 120,
            //    MoodId = 115,
            //    TopicId = 115,
            //    Lines= "viewing the dragon@@there they ride slim through my dream@@Carpaccio’s pair"


            //},
            //      new Poem
            //{
            //    Title="5 & 7 & 5 (Excerpt III)",
            //    Author="Anselm Hollo",
            //    FormId = 120,
            //    MoodId = 115,
            //    TopicId = 114,
            //    Lines= "wind rain you and me@@went looking for a new house@@o the grass grows loud"
            //},
            //         new Poem
            //{
            //    Title="5 & 7 & 5 (Excerpt IV)",
            //    Author="Anselm Hollo",
            //    FormId = 120,
            //    MoodId = 115,
            //    TopicId = 114,
            //    Lines= "slow bloom inside you@@the mnemonics of loving@@incessant chatter"
            //},
            //            new Poem
            //{
            //    Title="5 & 7 & 5 (Excerpt V)",
            //    Author="Anselm Hollo",
            //    FormId = 120,
            //    MoodId = 114,
            //    TopicId = 114,
            //    Lines= "@@far shore Ferris wheel@@turning glowing humming love@@in our lit-up heads"
            //},
            //               new Poem
            //{
            //    Title="5 & 7 & 5 (Excerpt VI)",
            //    Author="Anselm Hollo",
            //    FormId = 120,
            //    MoodId = 115,
            //    TopicId = 115,
            //    Lines= "switch them to sleep now@@the flying foxes swarm out@@great   it’s flurry time"

            //},

            //               new Poem
            //               {
            //                   Author="Yosa Buson",
            //                   Title="The Light of a Candle",
            //                   FormId = 120,
            //                   MoodId = 113,
            //                   TopicId = 115,
            //                   Lines="The light of a candle@@  is transferred to another candle—@@spring twilight."
            //               }
            };
            public Array GetPoems () {
            return PoemsArr;
            }
        };
    }
