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
                Title="The New Colossus",
                Author="Emma Lazarus",
                FormId = 118,
                MoodId = 113,
                TopicId = 115,
                Lines = "Not like the brazen giant of Greek fame,@@With conquering limbs astride from land to land;@@Here at our sea-washed, sunset gates shall stand@@A mighty woman with a torch, whose flame@@Is the imprisoned lightning, and her name@@Mother of Exiles. From her beacon-hand@@Glows world-wide welcome; her mild eyes command@@The air-bridged harbor that twin cities frame.@@'Keep, ancient lands, your storied pomp!' cries she@@With silent lips. 'Give me your tired, your poor,@@Your huddled masses yearning to breathe free,@@The wretched refuse of your teeming shore.@@Send these, the homeless, tempest-tost to me,@@I lift my lamp beside the golden door!' "
            },

            new Poem
            {
                Title="My Letters! all dead paper (Sonnet 28)",
                Author="Elizabeth Barrett Browning",
                FormId = 118,
                MoodId = 113,
                TopicId = 116,
                Lines="My letters! all dead paper, mute and white!@@And yet they seem alive and quivering@@Against my tremulous hands which loose the string@@And let them drop down on my knee tonight.@@This said—he wished to have me in his sight@@Once, as a friend: this fixed a day in spring@@To come and touch my hand. . . a simple thing,@@Yes I wept for it—this . . . the paper’s light. . .@@Said, Dear, I love thee; and I sank and quailed@@As if God’s future thundered on my past.@@This said, I am thine—and so its ink has paled@@With lying at my heart that beat too fast.@@And this . . . 0 Love, thy words have ill availed@@If, what this said, I dared repeat at last!"
            },

            new Poem
            {
                Author="Rainer Maria Rilke",
                Title="Sonnet 6",
                FormId=118,
                MoodId=115,
                TopicId=115,
                Lines="Is he native to this realm? No,@@his wide nature grew out of both worlds.@@They more adeptly bend the willow’s branches@@who have experience of the willow’s roots.@@@@When you go to bed, don’t leave bread or milk@@on the table: it attracts the dead—@@But may he, this quiet conjurer, may he@@beneath the mildness of the eyelid@@@@mix their bright traces into every seen thing;@@and may the magic of earthsmoke and rue@@be as real for him as the clearest connection.@@@@Nothing can mar for him the authentic image;@@whether he wanders through houses or graves,@@let him praise signet ring, gold necklace, jar."
            },

            new Poem
            {
                Title="I Shall Forget You Presently",
                Author="Edna St. Vincent Millay",
                MoodId=116,
                TopicId = 114,
                FormId=118,
                Lines="I shall forget you presently, my dear,@@So make the most of this, your little day,@@Your little month, your little half a year@@Ere I forget, or die, or move away,@@And we are done forever; by and by@@I shall forget you, as I said, but now,@@If you entreat me with your loveliest lie@@I will protest you with my favorite vow.@@I would indeed that love were longer-lived,@@And vows were not so brittle as they are,@@But so it is, and nature has contrived@@To struggle on without a break thus far,—@@Whether or not we find what we are seeking@@Is idle, biologically speaking."

            },

            new Poem
            {
                Title="Sunset",
                Author="e.e. cummings",
                FormId = 118,
                MoodId = 113,
                TopicId = 115,
                Lines="Great carnal mountains crouching in the cloud@@That marrieth the young earth with a ring,@@Yet still its thoughts builds heavenward, whence spring@@Wee villages of vapor, sunset-proud.—@@And to the meanest door hastes one pure-browed@@White-fingered star, a little, childish thing,@@The busy needle of her light to bring,@@And stitch, and stitch, upon the dead day’s shroud.@@Poises the sun upon his west, a spark@@Superlative,—and dives beneath the world;@@From the day’s fillets Night shakes out her locks;@@List! One pure trembling drop of cadence purled—@@“Summer!”—a meek thrush whispers to the dark.@@Hark! the cold ripple sneering on the rocks!"

            },

            new Poem
            {
                Title="Sonnet",
                Author="Alice Dunbar-Nelson",
                FormId=118,
                TopicId=114,
                MoodId=113,
                Lines="I had no thought of violets of late,      @@The wild, shy kind that spring beneath your feet@@In wistful April days, when lovers mate@@And wander through the fields in raptures sweet.@@The thought of violets meant florists’ shops,@@And bows and pins, and perfumed papers fine;@@And garish lights, and mincing little fops@@And cabarets and songs, and deadening wine. @@So far from sweet real things my thoughts had strayed, @@I had forgot wide fields, and clear brown streams;            @@The perfect loveliness that God has made,— @@Wild violets shy and Heaven-mounting dreams.@@And now—unwittingly, you’ve made me dream@@Of violets, and my soul’s forgotten gleam.    "
            }
            };
            public Array GetPoems () {
            return PoemsArr;
            }
        };
    }
