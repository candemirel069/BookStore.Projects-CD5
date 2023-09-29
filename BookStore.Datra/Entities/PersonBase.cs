using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Data.Entities
{
    public abstract class PersonBase : EntityBase
    {
        [Display(Name ="Adı")]
        public string Name { get; set; } = "";
        
        [Display(Name = "Soyadı")]
        public string Surname { get; set; } = "";

        [NotMapped]
        [Display(Name = "Adı Soyadı")]
        public string FullName=> Name+" "+Surname.ToUpper();
    }
}
