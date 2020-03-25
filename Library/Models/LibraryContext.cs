using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<BookAuthor> BookAuthor { get; set; }
    public DbSet<Patron> Patrons { get; set; }
    public DbSet<Checkout> Checkout { get; set; }
    public DbSet<Title> Titles { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}