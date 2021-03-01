using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Models.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PagingInfo Paginginfo { get; set; }
        //Paginginfo is an object
        public PagingInfo PagingInfo { get; set; }
        //srting is a variable
        public string CurrentCategory { get; set; }
    }
}
