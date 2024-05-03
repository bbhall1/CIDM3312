using Microsoft.EntityFrameworkCore;

namespace CIDM3312.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options)
            : base(options)
            {
            }

        public DbSet<Book> Books {get;set;} = default!;
        public DbSet<Review> Reviews {get;set;} = default!;
        public DbSet<Shelf> Shelves {get;set;} = default!;
    }
}