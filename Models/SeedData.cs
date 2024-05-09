using Microsoft.EntityFrameworkCore;

namespace CIDM3312.Models
{
    public static class SeedData
    {

            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new BookContext(
                    serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
                    {
                        if (context == null || context.Books == null)
                        {
                            throw new ArgumentNullException("Null RazorPagesBookContext");
                        }

                        //looking for the books
                        if (context.Books.Any())
                        {
                          return; //data seeded
                        }

                        context.Books.AddRange(
                            new Book
                            {
                                Title = "The Black Echo",
                                Author = "Michael Connelly",
                                Genre = "Mystery",
                                PublicationYear = DateOnly.Parse("1992-01-21"),
                                
                                Reviews = new List<Review>
                                {
                                    new Review 
                                    {
                                        Rating = 4,
                                        ReviewText = "Introduces LAPD Detective Harry Bosch as a gritty seasoned veteran of the force. Investigatinng a body located in a drainage pipe. The fast paced action kept me turning page after page to see how Bosch handled the investigation. I look forward to reading more in the series soon."
                                    },
                                    new Review
                                    {
                                        Rating = 5,
                                        ReviewText = "Intorducing Heronymous Bosch this book keeps you hooked from beginning to end."
                                    }
                                }

                               
                            },
                             new Book
                            {
                                Title = "One Hundred Years of Solitude",
                                Author = "Gabriel Garcia Marquez",
                                Genre = "Fiction",
                                PublicationYear = DateOnly.Parse("1967-01-01"),
                            },

                            new Book
                            {
                                Title = "To Kill a Mockingbird",
                                Author = "Harper Lee",
                                Genre = "Classic",
                                PublicationYear = DateOnly.Parse("1960-07-11"),

                                
                                Reviews = new List<Review>
                                {
                                    new Review 
                                    {
                                        Rating = 5,
                                        ReviewText = "A timeless classic confronting prejudice and injustice through Scout's innocent eyes. Harper Lee's poignant narrative resonates with moral courage and compassion."
                                    }                                
                                },

                             },

                              new Book
                            {
                                Title = "1984",
                                Author = "George Orwell",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("1949-06-08"),
                              

                                Reviews = new List<Review>
                                {
                                    new Review 
                                    {
                                        Rating = 5,
                                        ReviewText = "In George Orwell's '1984,' the oppressive regime of Oceania, ruled by the enigmatic Big Brother, strips citizens of their freedom and individuality. Winston Smith, a low-ranking member of the Party, dares to question the Party's propaganda and embarks on a dangerous journey of rebellion and self-discovery. Orwell's chilling depiction of surveillance, propaganda, and thought control serves as a stark warning against the dangers of totalitarianism and the manipulation of truth. Through Winston's harrowing experiences, Orwell explores themes of power, truth, memory, and the resilience of the human spirit in the face of tyranny. '1984' remains a haunting and prophetic work that continues to resonate with readers, challenging us to question authority, defend our freedoms, and safeguard the truth from those who seek to manipulate it."
                                    }
                                
                                },

                                
                            },
                              new Book
                            {
                                Title = "The Hitchhiker's Guide to the Galaxy",
                                Author = "Douglas Adams",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("1979-10-12"),
                                

                                Reviews = new List<Review>
                                {
                                    new Review 
                                    {
                                        Rating = 4,
                                        ReviewText = "A comedic masterpiece that takes readers on a wild intergalactic journey. With its quirky characters, absurd scenarios, and witty humor, the novel offers a delightful blend of science fiction and satire. From the hapless Arthur Dent to the enigmatic Ford Prefect and the perpetually depressed Marvin the Paranoid Android, each character adds to the hilarity and charm of the story. Adams' sharp wit and clever writing keep readers engaged from beginning to end, making it a must-read for fans of both science fiction and comedy. With its timeless humor and philosophical undertones, 'The Hitchhiker's Guide' continues to captivate audiences, proving that sometimes the best way to explore the universe is with a towel in hand and a sense of humor."
                                    }
                                
                                },

                                
                            },
                              new Book
                            {
                                Title = "The Catcher in the Rye",
                                Author = "JD Salinger",
                                Genre = "Fiction",
                                PublicationYear = DateOnly.Parse("1951-07-16"), 

                            },

                              new Book
                            {
                                Title = "Harry Potter and the Sorcerer's Stone",
                                Author = "JK Rowling",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("1997-06-26"), 
                               

                                Reviews = new List<Review>
                                {
                                    new Review 
                                    {
                                        Rating = 5,
                                        ReviewText = "A captivating introduction to the magical world of Hogwarts. J.K. Rowling's debut novel masterfully blends whimsy and adventure, whisking readers away on a journey of self-discovery alongside the young wizard, Harry Potter. From the moment Harry steps into Diagon Alley to his thrilling encounter with He Who Must Not Be Named, the story brims with wonder and excitement."
                                    }
                                
                                },
                            },

                              new Book
                            {
                                Title = "The Hobbit",
                                Author = "JRR Tolkien",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("1937-09-21"),

                               

                            },
                              new Book
                            {
                                Title = "The Hunger Games",
                                Author = "Suzanne Collinns",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2008-09-14"),
                            },

                              new Book
                            {
                                Title = "The Road",
                                Author = "Cormac McCarthy",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2006-09-26"),
                            },

                              new Book
                            {
                                Title = "The Martian",
                                Author = "Andy Weir",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2011-09-27"),                            
                            },

                              new Book
                            {
                                Title = "Moby-Dick",
                                Author = "Herman Melville",
                                Genre = "Classic",
                                PublicationYear = DateOnly.Parse("1851-10-18"),
                            },

                              new Book
                            {
                                Title = "The Lion, the Witch and the Wardrobe",
                                Author = "CS Lewis",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("1950-10-16"), 
                            },

                              new Book
                            {
                                Title = "The Name of the Wind",
                                Author = "Patrick Rothfuss",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("2007-03-27"), 

                                
                            },
                              new Book
                            {
                                Title = "Atomic Habits; An Easy & Proven Way to Build Good Habits & Break Bad Ones",
                                Author = "James Clear",
                                Genre = "Self-Help",
                                PublicationYear = DateOnly.Parse("2018-10-16"),
                            },

                              new Book
                            {
                                Title = "Empire of the Summer Moon",
                                Author = "SC Gwynne",
                                Genre = "Non-Fiction",
                                PublicationYear = DateOnly.Parse("2010-03-25"),    
                            },

                              new Book
                            {
                                Title = "Dungeon Crawler Carl",
                                Author = "Matt Dinniman",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2020-09-21"),    
                            },

                              new Book
                            {
                                Title = "I Am Legend",
                                Author = "Robert Matheson",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("1954-07-01"), 
                            },

                              new Book
                            {
                                Title = "The Sword of Kaigen",
                                Author = "ML Wang",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("2018-01-01"), 
                            },

                              new Book
                            {
                                Title = "Orconomics",
                                Author = "Zachary Pike",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("2014-09-30"), 

                                
                            },
                              new Book
                            {
                                Title = "I'm Glad My Mom Died",
                                Author = "Jennette McCurdy",
                                Genre = "Memoir",
                                PublicationYear = DateOnly.Parse("2022-08-09"), 

                                
                            },
                              new Book
                            {
                                Title = "Artemis Fowl",
                                Author = "Eoin Colfer",
                                Genre = "Young Adult",
                                PublicationYear = DateOnly.Parse("2001-04-26"), 

                                
                            },
                              new Book
                            {
                                Title = "All Systems Red",
                                Author = "Martha Wells",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2017-05-02"), 

                                
                            },

                              new Book
                            {
                                Title = "The Long Way to a Small, Angry Planet",
                                Author = "Becky Chambers",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2014-07-29"),                               
                            },

                              new Book
                            {
                                Title = "Dune",
                                Author = "Frank Herbert",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("1965-06-01"),                                 
                            },

                              new Book
                            {
                                Title = "Mistborn: The Final Empire",
                                Author = "Brandon Sanderson",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("2006-07-17"),                                 
                            },

                              new Book
                            {
                                Title = "The Pillars of the Earth",
                                Author = "Ken Follett",
                                Genre = "Historical Fiction",
                                PublicationYear = DateOnly.Parse("1989-10-01"),                                 
                            },

                              new Book
                            {
                                Title = "The Terminal List",
                                Author = "Jack Carr",
                                Genre = "Thriller",
                                PublicationYear = DateOnly.Parse("2018-03-16"),                                 
                            },

                              new Book
                            {
                                Title = "Wool",
                                Author = "Hugh Howey",
                                Genre = "Science Fiction",
                                PublicationYear = DateOnly.Parse("2011-07-29"),                                 
                            },

                              new Book
                            {
                                Title = "Of Blood and Fire",
                                Author = "Ryan Cahill",
                                Genre = "Fantasy",
                                PublicationYear = DateOnly.Parse("2021-03-20"),                                 
                            }
                        );
                      List<Shelf> shelves = new List<Shelf>
                      {
                        new Shelf {ShelfName = "To Be Read"},
                        new Shelf {ShelfName = "Read"},
                        new Shelf {ShelfName = "Currently Reading"}
                      };


                  context.SaveChanges();                          
                }
          }
  }
}

