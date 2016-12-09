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
               /* if (context.Poem.Count() > 2 )
                {
                    return;
                }*/

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
                         Lines = "I @@Among twenty snowy mountains,   @@The only moving thing   @@Was the eye of the blackbird.   @@@@II @@I was of three minds,   @@Like a tree   @@In which there are three blackbirds.   @@@@III @@The blackbird whirled in the autumn winds.   @@It was a small part of the pantomime.   @@@@IV @@A man and a woman   @@Are one.   @@A man and a woman and a blackbird   @@Are one.   @@@@V @@I do not know which to prefer,   @@The beauty of inflections   @@Or the beauty of innuendoes,   @@The blackbird whistling   @@Or just after.   @@@@VI @@Icicles filled the long window   @@With barbaric glass.   @@The shadow of the blackbird   @@Crossed it, to and fro.   @@The mood   @@Traced in the shadow   @@An indecipherable cause.   @@@@VII @@O thin men of Haddam,   @@Why do you imagine golden birds?   @@Do you not see how the blackbird   @@Walks around the feet   @@Of the women about you?   @@@@VIII @@I know noble accents   @@And lucid, inescapable rhythms;   @@But I know, too,   @@That the blackbird is involved   @@In what I know.   @@@@IX @@When the blackbird flew out of sight,   @@It marked the edge   @@Of one of many circles.   @@@@X @@At the sight of blackbirds   @@Flying in a green light,   @@Even the bawds of euphony   @@Would cry out sharply.   @@@@XI @@He rode over Connecticut   @@In a glass coach.   @@Once, a fear pierced him,   @@In that he mistook   @@The shadow of his equipage   @@For blackbirds.   @@@@XII @@The river is moving.   @@The blackbird must be flying.   @@@@XIII @@It was evening all afternoon.   @@It was snowing   @@And it was going to snow.   @@The blackbird sat   @@In the cedar-limbs.@@@@"
                     },

                     new Poem
                     {
                         Title = "The Love Song of J. Alfred Prufrock",
                         Author = "T.S. Eliot",
                         Collection = "Collected Poems",
                         PubDate = 1963,
                         MoodId = 3,
                         FormId = 1,
                         TopicId = 2,
                         Lines = "S’io credesse che mia risposta fosse @A persona che mai tornasse al mondo, @Questa fiamma staria senza piu scosse. @Ma percioche giammai di questo fondo @Non torno vivo alcun, s’i’odo il vero, @Senza tema d’infamia ti rispondo.@Let us go then, you and I, @When the evening is spread out against the sky @Like a patient etherized upon a table; @Let us go, through certain half-deserted streets, @The muttering retreats @Of restless nights in one-night cheap hotels @And sawdust restaurants with oyster-shells: @Streets that follow like a tedious argument @Of insidious intent @To lead you to an overwhelming question ... @Oh, do not ask, “What is it?” @Let us go and make our visit. @@In the room the women come and go @Talking of Michelangelo. @@The yellow fog that rubs its back upon the window-panes, @The yellow smoke that rubs its muzzle on the window-panes, @Licked its tongue into the corners of the evening, @Lingered upon the pools that stand in drains, @Let fall upon its back the soot that falls from chimneys, @Slipped by the terrace, made a sudden leap, @And seeing that it was a soft October night, @Curled once about the house, and fell asleep. @@And indeed there will be time @For the yellow smoke that slides along the street, @Rubbing its back upon the window-panes; @There will be time, there will be time @To prepare a face to meet the faces that you meet; @There will be time to murder and create, @And time for all the works and days of hands @That lift and drop a question on your plate; @Time for you and time for me, @And time yet for a hundred indecisions, @And for a hundred visions and revisions, @Before the taking of a toast and tea. @@In the room the women come and go @Talking of Michelangelo. @@And indeed there will be time @To wonder, “Do I dare?” and, “Do I dare?” @Time to turn back and descend the stair, @With a bald spot in the middle of my hair — @(They will say: “How his hair is growing thin!”) @My morning coat, my collar mounting firmly to the chin, @My necktie rich and modest, but asserted by a simple pin — @(They will say: “But how his arms and legs are thin!”) @Do I dare @Disturb the universe? @In a minute there is time @For decisions and revisions which a minute will reverse. @@For I have known them all already, known them all: @Have known the evenings, mornings, afternoons, @I have measured out my life with coffee spoons; @I know the voices dying with a dying fall @Beneath the music from a farther room. @               So how should I presume? @@And I have known the eyes already, known them all— @The eyes that fix you in a formulated phrase, @And when I am formulated, sprawling on a pin, @When I am pinned and wriggling on the wall, @Then how should I begin @To spit out all the butt-ends of my days and ways? @               And how should I presume? @@And I have known the arms already, known them all— @Arms that are braceleted and white and bare @(But in the lamplight, downed with light brown hair!) @Is it perfume from a dress @That makes me so digress? @Arms that lie along a table, or wrap about a shawl. @               And should I then presume? @               And how should I begin? @@Shall I say, I have gone at dusk through narrow streets @And watched the smoke that rises from the pipes @Of lonely men in shirt-sleeves, leaning out of windows? ... @@I should have been a pair of ragged claws @Scuttling across the floors of silent seas. @@And the afternoon, the evening, sleeps so peacefully! @Smoothed by long fingers, @Asleep ... tired ... or it malingers, @Stretched on the floor, here beside you and me. @Should I, after tea and cakes and ices, @Have the strength to force the moment to its crisis? @But though I have wept and fasted, wept and prayed, @Though I have seen my head (grown slightly bald) brought in upon a platter, @I am no prophet — and here’s no great matter; @I have seen the moment of my greatness flicker, @And I have seen the eternal Footman hold my coat, and snicker, @And in short, I was afraid. @@And would it have been worth it, after all, @After the cups, the marmalade, the tea, @Among the porcelain, among some talk of you and me, @Would it have been worth while, @To have bitten off the matter with a smile, @To have squeezed the universe into a ball @To roll it towards some overwhelming question, @To say: “I am Lazarus, come from the dead, @Come back to tell you all, I shall tell you all”— @If one, settling a pillow by her head @               Should say: “That is not what I meant at all; @               That is not it, at all.” @@And would it have been worth it, after all, @Would it have been worth while, @After the sunsets and the dooryards and the sprinkled streets, @After the novels, after the teacups, after the skirts that trail along the floor— @And this, and so much more?— @It is impossible to say just what I mean! @But as if a magic lantern threw the nerves in patterns on a screen: @Would it have been worth while @If one, settling a pillow or throwing off a shawl, @And turning toward the window, should say: @               “That is not it at all, @               That is not what I meant, at all.” @@No! I am not Prince Hamlet, nor was meant to be; @Am an attendant lord, one that will do @To swell a progress, start a scene or two, @Advise the prince; no doubt, an easy tool, @Deferential, glad to be of use, @Politic, cautious, and meticulous; @Full of high sentence, but a bit obtuse; @At times, indeed, almost ridiculous— @Almost, at times, the Fool. @@I grow old ... I grow old ... @I shall wear the bottoms of my trousers rolled. @@Shall I part my hair behind?   Do I dare to eat a peach? @I shall wear white flannel trousers, and walk upon the beach. @I have heard the mermaids singing, each to each. @@I do not think that they will sing to me. @@I have seen them riding seaward on the waves @Combing the white hair of the waves blown back @When the wind blows the water white and black. @We have lingered in the chambers of the sea @By sea-girls wreathed with seaweed red and brown @Till human voices wake us, and we drown.@@"
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

