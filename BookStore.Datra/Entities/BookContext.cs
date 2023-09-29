using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Entities
{
    public class Book : EntityBase
    {       
        public string Name { get; set; }
        public int? PageCount { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        public int? TranslatorId { get; set; }
        public Translator? Translator { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
    public class Translator : PersonBase
    {
        public List<Book>? Books { get; set; }
    }
    public class Author : PersonBase
    {
        public List<Book>? Books { get; set; }
    }

    public class Category : EntityBase
    {
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage ="Kategori adı mecburidir")]
        [StringLength(50)]
        public string Name { get; set; }
        public List<Book>? Books { get; set; }
    }

    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Translator> Translators { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public BookContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BookStoreDB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .Property(col => col.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Sanat" },
                new Category { Id = 2, Name = "Bilim" },
                new Category { Id = 3, Name = "Felsefe" },
                new Category { Id = 4, Name = "Matematik" },
                new Category { Id = 5, Name = "Fizik" }
                );
        }
    }
}
