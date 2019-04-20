using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksList.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Book Name")]
        public string Name { get; set; }

        public string ISBN { get; set; }

        public int Author { get; set; }
    }
}