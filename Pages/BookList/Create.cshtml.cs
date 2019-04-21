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
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {   
            
        }

        public async Task<IActionResult> OnPost()
        {
            if (! ModelState.IsValid)
            {
                return Page();
            }

            _db.Book.Add(Book);
            await _db.SaveChangesAsync();

            Message = "Book has been created successfully.";

            return RedirectToPage("Index");
        }
    }
}