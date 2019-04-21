using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BooksList.Pages.BookList
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }
        
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
    }
}