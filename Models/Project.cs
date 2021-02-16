using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5.Models
{
    public class Project
    {
        //setting up a primary key
        [Key]
        public int Bookid { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^\d{2,3}[-]{0,1}\d{10}|\d{9,11}$", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Price { get; set; }

    }
}
