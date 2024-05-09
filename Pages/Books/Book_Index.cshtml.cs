using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using CIDM3312.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SQLitePCL;



namespace CIDM3312.Pages.Books
{

    public class Book_IndexModel : PageModel
    {
        private readonly CIDM3312.Models.BookContext _context;

        public Book_IndexModel(CIDM3312.Models.BookContext context)
        {
            _context = context;
        }
        
        public IList<Book>? Books {get;set;} = default!;
        
        public IList<Review>? Reviews {get;set;} = default!;
        
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        public SelectList SortList {get; set;} = default!;


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

                Books = await books.Select(b => b.Book).ToListAsync();
        }

        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                
                var query = _context.Books.Select(p => p);
                List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "Title_Ascending", Value = "title_asc" },
                    new SelectListItem { Text = "Title_Descending", Value = "title_desc"}
                };
                SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

                switch (CurrentSort)
                {
                    // If user selected "first_asc", modify query to sort by first name ascending order
                    case "title_asc": 
                        query = query.OrderBy(p => p.Title);
                        break;
                    // If user selected "first_desc", modify query to sort by first name descending
                    case "title_desc":
                        query = query.OrderByDescending(p => p.Title);
                        break;
                    // Add more sorting cases as needed
                }

                // Retrieve just the professors for the page we are on
                // Use .Skip() and .Take() to select them
                Books = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    }
}
