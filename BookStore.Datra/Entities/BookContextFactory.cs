using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookStore.Data.Entities
{
    public class BookContextFactory : IDesignTimeDbContextFactory<BookContext>
    {
        public BookContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BookStoreDB;Integrated Security=true");

            return new BookContext(optionsBuilder.Options);
        }
    }
}
