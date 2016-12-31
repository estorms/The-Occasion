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

               
                    {
                        var authors = new Author[] {

                    new Author
                    {
                       Name = "Wallace Stevens",
                       Bio= "Wallace Stevens was an American Modernist poet. He was born in Reading, Pennsylvania, educated at Harvard and then New York Law School, and he spent most of his life working as an executive for an insurance company in Hartford, Connecticut. He was born in 1879 in Reading, PA, and died in 1955 in Hartford, CT. His best-known works include 'The Snowman', 'The Emperor of Ice Cream', and '13 Ways of Looking at a Blackbird.'"
                    },

                    new Author
                    {
                        Name = "Larry Levis",
                        Bio="Poet Larry Levis, whose collection The Afterlife won the Lamont Poetry Prize, often employed an imagist or surrealist approach in his work. As Diane Wakoski wrote in Contemporary Poets, Levis's 'work is best when the poems are short and are shaped by his imagist instincts or his gestures towards surrealism. He is a master of the brief moment of recognition where the personal is embedded in the generic . . . and the least effective when he allows nostalgia to reign over or shape his poems.' Poet Larry Levis, whose collection The Afterlife won the Lamont Poetry Prize, often employed an imagist or surrealist approach in his work. As Diane Wakoski wrote in Contemporary Poets, Levis's 'work is best when the poems are short and are shaped by his imagist instincts or his gestures towards surrealism. He is a master of the brief moment of recognition where the personal is embedded in the generic . . . and the least effective when he allows nostalgia to reign over or shape his poems.'"
                    },
                    new Author
                    {
                         Name = "Emily Dickinson",
                         Bio="Emily Elizabeth Dickinson was an American poet. Dickinson was born in Amherst, Massachusetts. Although part of a prominent family with strong ties to its community, Dickinson lived much of her life in reclusive isolation. Dickinson’s poetry was heavily influenced by the Metaphysical poets of seventeenth-century England, as well as her reading of the Book of Revelation and her upbringing in a Puritan New England town, which encouraged a Calvinist, orthodox, and conservative approach to Christianity."
                    },

                    new Author
                    {
                        Name = "William Butler Yeats",
                        Bio="William Butler Yeats was an Irish poet and one of the foremost figures of 20th-century literature. A pillar of both the Irish and British literary establishments, he helped the foundation of the Abbey Theatre, and in his later years served as an Irish Senator for two terms and was a driving force behind the Irish Literary Revival along with Lady Gregory, Edward Martyn and others. He was born in Sandymount, Ireland and educated there and in London. He spent childhood holidays in County Sligo and studied poetry from an early age when he became fascinated by Irish legends and the occult. These topics feature in the first phase of his work, which lasted roughly until the turn of the 20th century. His earliest volume of verse was published in 1889, and its slow-paced and lyrical poems display Yeats's debts to Edmund Spenser, Percy Bysshe Shelley, and the poets of the Pre-Raphaelite Brotherhood. From 1900, Yeats's poetry grew more physical and realistic. He largely renounced the transcendental beliefs of his youth, though he remained preoccupied with physical and spiritual masks, as well as with cyclical theories of life. In 1923, he was awarded the Nobel Prize in Literature."
                    }
                        };

                        foreach (Author a in authors)
                        {
                            context.Author.Add(a);
                        }
                        context.SaveChanges();
                    }
                }
            }
        }
    }

        
                
