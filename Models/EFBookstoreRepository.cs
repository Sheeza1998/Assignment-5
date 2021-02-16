using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Models
{
    public class EFBookstoreRepository : BookstoreRepository
    {
        private BookstoreDBcontext _context;
        
        //Constructor
        public EFBookstoreRepository (BookstoreDBcontext context)
        {
            _context = context;
        }
        public IQueryable<Project> Pros => _context.Projects;
    }
}
