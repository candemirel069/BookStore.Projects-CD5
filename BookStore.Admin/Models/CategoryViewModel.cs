using System.ComponentModel.DataAnnotations;

namespace BookStore.Admin.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Display(Name="Kategori Adı")]
        public string Name { get; set; }

        [Display(Name = "Kitap Sayısı")]
        public int BookCount { get; set; } 
    }
}
