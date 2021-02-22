using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Assignment_5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDBcontext context = application.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<BookstoreDBcontext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        Title = "Les Miserables",
                        Author_FirstName = "Victor",
                        Author_MiddleName = null,
                        Author_LastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },

                    new Project
                    {
                        Title = "Team of Rivals",
                        Author_FirstName = "Doris",
                        Author_MiddleName = "Kearns",
                        Author_LastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography ",
                        Price = 14.58,
                        Pages = 944
                    },

                    new Project
                    {
                        Title = "The Snowball",
                        Author_FirstName = "Alice",
                        Author_MiddleName = null,
                        Author_LastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography ",
                        Price = 21.54,
                        Pages = 832
                    },

                    new Project
                    {
                        Title = "American Ulysses",
                        Author_FirstName = "Ronald",
                        Author_MiddleName = null,
                        Author_LastName = "C.White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography ",
                        Price = 11.61,
                        Pages = 864
                    },

                    new Project
                    {
                        Title = "Unbroken",
                        Author_FirstName = "Laura",
                        Author_MiddleName = null,
                        Author_LastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492 ",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        Pages = 528
                    },

                    new Project
                    {
                        Title = "The Great Train Robbery",
                        Author_FirstName = "Michael",
                        Author_MiddleName = null,
                        Author_LastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288
                    },

                    new Project
                    {
                        Title = "Deep Work",
                        Author_FirstName = "Cal",
                        Author_MiddleName = null,
                        Author_LastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        Pages = 304
                    },

                    new Project
                    {
                        Title = "It's Your Ship",
                        Author_FirstName = "Michael",
                        Author_MiddleName = null,
                        Author_LastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        Pages = 240
                    },

                    new Project
                    {
                        Title = "The Virgin Way",
                        Author_FirstName = "Richard",
                        Author_MiddleName = null,
                        Author_LastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        Pages = 400
                    },

                    new Project
                    {
                        Title = "Sycamore Row",
                        Author_FirstName = "John",
                        Author_MiddleName = null,
                        Author_LastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        Pages = 642
                    },

                    new Project
                    {
                        Title = "Pride & Prejudice",
                        Author_FirstName = "Jane",
                        Author_MiddleName = null,
                        Author_LastName = "Austen",
                        Publisher = "T. Egerton",
                        ISBN = "978-1435171589",
                        Classification = "Non-Fiction",
                        Category = "Romance",
                        Price = 9.99,
                        Pages = 408
                    },

                    new Project
                    {
                        Title = "To Kill a Mockingbird",
                        Author_FirstName = "Harper",
                        Author_MiddleName = null,
                        Author_LastName = "Lee",
                        Publisher = "J. B. Lippincott & Co.",
                        ISBN = "978-0553393613",
                        Classification = "Non-Fiction",
                        Category = "Suspense",
                        Price = 7.19,
                        Pages = 281
                    },

                    new Project
                    {
                        Title = "1984",
                        Author_FirstName = "George",
                        Author_MiddleName = null,
                        Author_LastName = "Orwell",
                        Publisher = "Harvill Secker",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Science Fiction",
                        Price = 7.15,
                        Pages = 328
                    }

                    );

                context.SaveChanges();
            }
        }

    }
}
