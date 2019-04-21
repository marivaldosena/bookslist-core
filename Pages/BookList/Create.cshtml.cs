using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BooksList.Pages.BookList
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {   
            
        }
    }
}