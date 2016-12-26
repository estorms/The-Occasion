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
                Title="The Ghazal of What Hurt",
                Author="Peter Cole",
                FormId = 119,
                TopicId=115,
                MoodId=116,
                Lines="Let them be, the battles you fought, in silence.@@Bury your shame, the worst you thought, in silence.@@@@At last my Beloved has haggled with death.@@‘One more day’ was the pearl she bought in silence.@@@@At night she heard the blacksmith hammering chains,@@at dawn the saw, the fretwork wrought in silence.@@@@‘The only wrong I’ve done is to live too long,'@@my Beloved’s eyes tell the court in silence.@@@@She’s as young as the month of Ordibehesht,@@month of my birth, spring’s mid-leap caught in silence.@@@@My Beloved, under the shade of a palm,@@was the girl, the mother I sought in silence.@@@@Loneliness is innumerate. Days slip by,@@suns rise that daylight moons distort in silence.@@@@The bell on her wrist was silent, her fingers@@ice cold as the julep she brought in silence.@@@@'Mimijune! Mimijune!' My Beloved’s voice@@climbs three steep notes for tears to thwart in silence.@@@@Three syllables of equal weight, equal stress,@@dropped in a well, keep falling short in silence."
            },

                new Poem
            {
                Title="America the Beautiful",
                Author="Alicia Ostriker",
                FormId = 119,
                TopicId=114,
                MoodId=113,
                Lines="Do you remember our earnestness our sincerity@@in first grade when we learned to sing America@@The Beautiful along with the Star-Spangled Banner@@and say the Pledge of Allegiance to America@@We put our hands over our first grade hearts@@we felt proud to be citizens of America@@I said One Nation Invisible until corrected@@maybe I was right about America@@School days school days dear old Golden Rule Days@@when we learned how to behave in America@@What to wear, how to smoke, how to despise our parents@@who didn’t understand us or America@@Only later learning the Banner and the Beautiful@@live on opposite sides of the street in America@@Only later discovering the Nation is divisible@@by money by power by color by gender by sex America@@We comprehend it now this land is two lands@@one triumphant bully one still hopeful America@@Imagining amber waves of grain blowing in the wind@@purple mountains and no homeless in America@@Sometimes I still put my hand tenderly on my heart@@somehow or other still carried away by America@@"
            },

                    new Poem
            {
                Title="All Other Loves",
                Author="Karen Winterburn",
                FormId = 119,
                TopicId=114,
                MoodId=116,
                Lines="The Infant Warrior sings in every tongue, inflames all other loves.@@Beware ravishings of the swaddled One who contains all other loves.@@@@When did my desire turn on me with its green hunger, its hollow teeth?@@My craving craves me back: pinched and jealous god who slays all other loves.@@@@Poplars glint and shimmy in their spangled chorus line. They shiver, swept@@by gusty fingers of a flirting sylph who disdains all other loves.@@@@I abandon my mandrake garden. Now cankered roots poison the ground.@@Juicy djinn's eggs, stolen for my silver bowl, red-stain all other loves.@@@@Moses said. Moses said. He's dead. All the Earth is Egypt in the egg.@@O Exodus hatched from the plagues of those gods, unchain all other loves.@@@@Language ladled into Karen like alphabet soup from deep Word wells:@@bright clad children queue to crazy-quilt the looped refrain, 'all other loves'."
            },

                    new Poem
                    {
                        Title="Ghazal Upon Hearing of a Mutual Friend's Death",
                        Author="Beatriz F. Fernandez",
                        FormId = 119,
                        TopicId = 113,
                        MoodId = 116,
                        Lines = "I went back to that pier today where we three met last time—@@sipped beer at the Sleepy Pelican— still there after all this time.@@Back then the chance to leave the island arrived as a godsend,@@but we swore we’d return and reunite in ten years’ time.@@How could we have guessed whose star would later ascend,@@or foreseen who’d first meet with the freak accidents time@@would send? He never made it past forty, he wasn’t able to pretend,@@like us, that each birthday meant we’d somehow trumped time’s@@stratagems. How did you hear, how were you able to fend@@off your own mind’s terrible questions, knowing all the time@@that no one loved him the way we did, half-brother, half-friend,@@and no one’s around to remember him with, not this time.@@Could I swallow the words that ended our friendship, make amends?@@Though I know mere words won’t reverse the tides of time,@@if I could get word back to you, what message would I send?@@Something only you would understand, as you did, once upon a time.@@Just remember me the way bees remember, my old friend,@@and bring her back home who once gave you joy, now lost in time.@@"
                    },

                       new Poem
                    {
                        Title="Ghazal Upon Hearing of a Mutual Friend's Death",
                        Author="Beatriz F. Fernandez",
                        FormId = 119,
                        TopicId = 113,
                        MoodId = 113,
                        Lines = "I went back to that pier today where we three met last time—@@sipped beer at the Sleepy Pelican— still there after all this time.@@Back then the chance to leave the island arrived as a godsend,@@but we swore we’d return and reunite in ten years’ time.@@How could we have guessed whose star would later ascend,@@or foreseen who’d first meet with the freak accidents time@@would send? He never made it past forty, he wasn’t able to pretend,@@like us, that each birthday meant we’d somehow trumped time’s@@stratagems. How did you hear, how were you able to fend@@off your own mind’s terrible questions, knowing all the time@@that no one loved him the way we did, half-brother, half-friend,@@and no one’s around to remember him with, not this time.@@Could I swallow the words that ended our friendship, make amends?@@Though I know mere words won’t reverse the tides of time,@@if I could get word back to you, what message would I send?@@Something only you would understand, as you did, once upon a time.@@Just remember me the way bees remember, my old friend,@@and bring her back home who once gave you joy, now lost in time.@@"
                    },

                       new Poem
                       {
                           Author="Sherman Alexie",
                           Title="Powwow Ghazal",
                           TopicId=115,
                           MoodId=113,
                           FormId = 119,
                           Lines="Can you hear the drums? Can you hear the drums?@@Tonight, the reservation is aflame with drums.@@Who’s that drum group? They’re good, but they’re kids.@@They have no idea how their lives will change with drums.@@And what about those drummers? O, they’re old school.@@They’re everybody’s elders. They’ve gone gray with drums.@@O, listen to that singer! He’s equal parts joy and hurt.@@His hands and vocal cords are bloodstained with drums.@@Damn, look at that fancy dancer spin in circles.@@She’s weeping! The girl is going insane with drums.@@Who’s the head man dancer? He’s been sober for ten years.@@Now he only gets drunk, stoned, and dazed with drums.@@Who’s the head woman dancer? That’s a grandmother.@@She speaks in sermons. She offers us grace with drums.@@That jingle dancer, ah, she’s a reservation beauty.@@Talk to her, cousin, because you can get laid with drums.@@That nostalgic Indian is wearing blue suede shoes.@@He’s the Indian Elvis, mixing his pomade with drums.@@Hey, look at that tribal cop with a shiny badge and gun.@@She wants to solve a crime. She’s Sam Spade with drums.@@But don’t forget that powwows can be dangerous, too.@@You better duck or get punched in the face with drums.@@Do you have a question? It can be answered here.@@There is nothing that can’t be explained with drums.@@No, I’m lying. Indians are glorious deceivers.@@We love to obscure, obfuscate, and exaggerate with drums.@@During powwow, even God wants to sing and dance,@@So God makes thunder, lightning, and rain with drums.@@Nobody has gone to bed yet. We’ve been awake for days.@@I sometimes think that every Indian is made with drums."
                       }
            };
            public Array GetPoems () {
            return PoemsArr;
            }
        };
    }
