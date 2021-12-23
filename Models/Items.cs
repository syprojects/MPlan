using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public enum ItemCategory
    {
        [Display(Name = "Kitap")]
        Book,
        [Display(Name = "Film")]
        Movie,
        [Display(Name = "Eğitim")]
        Training,
        [Display(Name = "Aktivite")]
        Activity
    }
    public class Items
    {
        [Key]
        public int Id { get; set; }
        //Category is Book, movie, training, etc.
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Görev Adı")]
        public string Name { get; set; }

        [Display(Name ="Kategori")]
        [Required(ErrorMessage = "Bu alan zorunlu")]
        public ItemCategory Category { get; set; }

        //BelongsTo is Autohor if it is a book
        [Display(Name = "Yazarı/Eğitimci")]
        public string BelongsTo { get; set; }
        [Display(Name = "URL")]
        [RegularExpression(@"(https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|www\.[a-zA-Z0-9][a-zA-Z0-9-]+[a-zA-Z0-9]\.[^\s]{2,}|https?:\/\/(?:www\.|(?!www))[a-zA-Z0-9]+\.[^\s]{2,}|www\.[a-zA-Z0-9]+\.[^\s]{2,})", ErrorMessage ="URL geçerli değil")]
        public string URL { get; set; }
        public ICollection<Plans> Plan { get; set; }
        public ICollection<ItemPoints> Point { get; set; }
        public ICollection<ItemComments> Comment { get; set; }
    }
}
