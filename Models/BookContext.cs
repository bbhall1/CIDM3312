using Microsoft.EntityFrameworkCore;

namespace CIDM3312.Models
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
            {
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shelf>().HasKey(s => new {s.BookID, s.ShelfID});
        }

        public DbSet<Book> Books {get;set;} = default!;
        public DbSet<Review> Reviews {get;set;} = default!;
        public DbSet<Shelf> Shelves {get;set;} = default!;
    }
}