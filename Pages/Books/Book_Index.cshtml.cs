using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using CIDM3312;
using CIDM3312.Models;

namespace CIDM3312.Pages.Books
{
    public class Book_IndexModel : PageModel
    {
        private readonly CIDM3312.Models.BookContext _context;

        public Book_IndexModel(CIDM3312.Models.BookContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            var books = from b in _context.Books
                    select new { Book = b, AverageRating = b.Reviews.Any() ? b.Reviews.Average(r => r.Rating) : (double?)null }; // Calculate average rating

            if (!String.IsNullOrEmpty(searchString))
            {   
                books = books.Where(s => s.Book.Title.Contains(searchString)
                    || s.Book.Author.Contains(searchString));
            }

            Book = await books.Select(b => b.Book).ToListAsync();
        }
    }
}
