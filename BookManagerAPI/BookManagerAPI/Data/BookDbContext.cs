using Microsoft.EntityFrameworkCore;
using BookManagerAPI.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookManagerAPI.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        public DbSet<Book> Books => Set<Book>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { BookID = 1, Title = "Encyclopedia Of Life", Author = "Miles Kelly", Price = 250.00M },
                new Book { BookID = 2, Title = "Matilda", Author = "Roald Dahl", Price = 345.68M },
                new Book { BookID = 3, Title = "Diary of a Wimpy Kid", Author = "Jeff Kinney", Price = 199.99M },
                new Book { BookID = 4, Title = "Secrets of a Champion", Author = "Jannie Putter", Price = 189.50M },
                new Book { BookID = 5, Title = "Fallen", Author = "Lauren Kate", Price = 225.75M },
                new Book { BookID = 6, Title = "Diary of a Wimpy Kid: Rodrick Rules", Author = "Jeff Kinney", Price = 210.00M },
                new Book { BookID = 7, Title = "Diary of a Wimpy Kid: The Last Straw", Author = "Jeff Kinney", Price = 205.50M },
                new Book { BookID = 8, Title = "Diary of a Wimpy Kid: Dog Days", Author = "Jeff Kinney", Price = 215.75M },
                new Book { BookID = 9, Title = "The Birth of Tragedy", Author = "Friedrich Nietzsche", Price = 310.99M }

            );
        }
    }
}