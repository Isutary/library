using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
    }
}
