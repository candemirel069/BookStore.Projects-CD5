using System.ComponentModel.DataAnnotations;

namespace BookStore.Admin.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        
        [Display(Name ="Tam Adı")]
        public string FullName { get; set; }

        [Display(Name = "Kitap sayısı")]
        public int  BookCount { get; set; }
    }
}
