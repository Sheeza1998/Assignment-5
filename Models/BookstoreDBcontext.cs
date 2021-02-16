using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Models
{
    public class BookstoreDBcontext : DbContext
    {
        //building  constructor  - when the instance of the object is built the first time
        
        public BookstoreDBcontext (DbContextOptions<BookstoreDBcontext> contextOptions) : base (contextOptions)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
