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
                Author="Samuel Taylor Coleride",
                Title="Kubla Khan (Or, a vision in a dream. A Fragment.)",
                FormId = 117,
                MoodId = 114,
                TopicId = 115,
                Lines=" In Xanadu did Kubla Khan @@A stately pleasure-dome decree: @@Where Alph, the sacred river, ran @@Through caverns measureless to man @@   Down to a sunless sea. @@So twice five miles of fertile ground @@With walls and towers were girdled round; @@And there were gardens bright with sinuous rills, @@Where blossomed many an incense-bearing tree; @@And here were forests ancient as the hills, @@Enfolding sunny spots of greenery. @@@@But oh! that deep romantic chasm which slanted @@Down the green hill athwart a cedarn cover! @@A savage place! as holy and enchanted @@As e’er beneath a waning moon was haunted @@By woman wailing for her demon-lover! @@And from this chasm, with ceaseless turmoil seething, @@As if this earth in fast thick pants were breathing, @@A mighty fountain momently was forced: @@Amid whose swift half-intermitted burst @@Huge fragments vaulted like rebounding hail, @@Or chaffy grain beneath the thresher’s flail: @@And mid these dancing rocks at once and ever @@It flung up momently the sacred river. @@Five miles meandering with a mazy motion @@Through wood and dale the sacred river ran, @@Then reached the caverns measureless to man, @@And sank in tumult to a lifeless ocean; @@And ’mid this tumult Kubla heard from far @@Ancestral voices prophesying war! @@   The shadow of the dome of pleasure @@   Floated midway on the waves; @@   Where was heard the mingled measure @@   From the fountain and the caves. @@It was a miracle of rare device, @@A sunny pleasure-dome with caves of ice! @@   A damsel with a dulcimer @@   In a vision once I saw: @@   It was an Abyssinian maid @@   And on her dulcimer she played, @@   Singing of Mount Abora. @@   Could I revive within me @@   Her symphony and song, @@   To such a deep delight ’twould win me, @@That with music loud and long, @@I would build that dome in air, @@That sunny dome! those caves of ice! @@And all who heard should see them there, @@And all should cry, Beware! Beware! @@His flashing eyes, his floating hair! @@Weave a circle round him thrice, @@And close your eyes with holy dread @@For he on honey-dew hath fed, @@And drunk the milk of Paradise.@@."
            },

             new Poem
             {
                 Author="Ezra Pound",
                 Title="April",
                 Lines="Three spirits came to me@@And drew me apart@@To where the olive boughs@@Lay stripped upon the ground:@@Pale carnage beneath bright mist",
                 FormId=117,
                 MoodId=115,
                 TopicId=113,

             },
             new Poem
             {
                 Author="Karen Volkman",
                 Title="Sonnet [Laughing below, the unimagined room]",
                 Lines="Laughing below, the unimagined room@@in unimagined mouths, a turning mood@@speaking itself the way a fulling should@@overspilling into something’s dome,@@some moment’s edging over into bloom.@@What is a happening but conscious cloud@@seeking its edge in a wound or word@@pellucidity describing term@@as boundary, body, violated bourne@@no sounding center, circumscription turn.@@Mother of mirrors, angel of the acts,@@do all the sighing breathing clicking wilds@@summon the same blue breadth the sense subtracts,@@the star suborning in its ruptured fields.",
                 FormId= 118,
                 MoodId=115,
                 TopicId =115
             },

             new Poem
             {
                 Author="Karen Volkman",
                 Title="Sonnet",
                 Lines="Tilt the placeless waver of this moving @@over the wanton waters—spiral storm @@hates the harmonies the days conform, @@orage orgueil, an intenser proving @@lashing its vassals, a form of loving. @@Dolor, choler, how the moods deform @@this ruse of light red rudiments perform— @@horse and horse, fox fox, fast flick and fauving, @@emblems in their leap and scrap, the livid nerving @@worlds consume, design, and name a grieving. @@Your impenitent animal: sky-pelt, @@net and gnaw, and claw and fleet and swerving; @@day’s raw quiddities that roar a leaving; @@eye-gold arrows, pierce-pulse; a failing felt.",
                 FormId=118,
                 MoodId=113,
                 TopicId=115
             },

             new Poem
             {
                 Author="Luisa A. Igloria",
                 Title="Erecho Ghazal",
                 Lines="And the high winds bore down, and the sky @@built up that grey wall: derecho.@@The taverns by the sea closed their shutters, @@and the stands selling battered fries, derech@@On the boardwalk, pieces of salt-water taffy, half-@@eaten funnel cakes oozing grease and cream: derecho.@@And the people on every highway, panicked, sought @@a clear route for their exodus: derecho.@@What’s in your emergency backpack? Beef jerky, mineral @@water, flashlight, solar cells? Snap in the sound of derecho.@@Yesterday, white and blue sails pretty on the water; @@sharp glint of skyscraper glass. Then this derecho",
                 MoodId=116,
                 TopicId=115,
                 FormId = 119
             }
            };
        public Array GetPoems()
        {
            return PoemsArr;
        }

        public Array AuthorsArr = new Author[] {

            new Author  {
                Name = "Luisa A. Igloria",
                Bio = "Luisa A. Igloria is the author of more than a dozen collections of poetry, including Ode to the Heart Smaller than a Pencil Eraser (2014), selected by Mark Doty for a May Swenson Poetry Award; The Saints of Streets (2013), winner of a Gintong Aklat Award; Juan Luna’s Revolver (2009), winner of the 2009 Sandeen Prize from the University of Notre Dame; Trill & Mordent (2005); and In the Garden of the Three Islands (1994). Since 2010, Igloria has written a new poem every day, a practice she shares on the literary blog Via Negativa. "
                },

            new Author {
                Name = "Ezra Pound",
                Bio= "Ezra Weston Loomis Pound (30 October 1885 – 1 November 1972) was an expatriate American poet and critic, and a major figure in the early modernist movement. His contribution to poetry began with his development of Imagism, a movement derived from classical Chinese and Japanese poetry, stressing clarity, precision and economy of language. His best-known works include Ripostes (1912), Hugh Selwyn Mauberley (1920) and the unfinished 120-section epic, The Cantos (1917–1969)."

            },

            new Author
            {
                Name="William Wordsworth",
                Bio="William Wordsworth was a major English Romantic poet who, with Samuel Taylor Coleridge, helped to launch the Romantic Age in English literature with their joint publication Lyrical Ballads. Hew was born in 1770 and died in 1850."
            },

            new Author
            {
                Name="Samuel Taylor Coleridge",
                Bio="Samuel Taylor Coleridge is the premier poet-critic of modern English tradition, distinguished for the scope and influence of his thinking about literature as much as for his innovative verse. Active in the wake of the French Revolution as a dissenting pamphleteer and lay preacher, he inspired a brilliant generation of writers and attracted the patronage of progressive men of the rising middle class. As William Wordsworth’s collaborator and constant companion in the formative period of their careers as poets, Coleridge participated in the sea change in English verse associated with Lyrical Ballads (1798). His poems of this period, speculative, meditative, and strangely oracular, put off early readers but survived the doubts of Wordsworth and Robert Southey to become recognized classics of the romantic idiom."
            },

            new Author
            {
                Name = "Karen Volkman",
                Bio="Karen Volkman, author of Whereso (BOA Editions, 2016), is the recipient of the James Laughlin Award, given by the Academy of American Poets, and the Iowa Poetry Prize."
            }

        };

            public Array GetAuthors()
        {
            return AuthorsArr;
        }
    }
}



