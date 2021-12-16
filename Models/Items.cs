using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public enum ItemCategory
    {
        Book,
        Film,
        Training,
        Activity
    }
    public class Items
    {
        [Key]
        public int Id { get; set; }
        //Category is Book, movie, training, etc.
        [Required]
        [Display(Name = "Görev Adı")]
        public string Name { get; set; }

        [Display(Name ="Kategori")]
        [Required]
        public ItemCategory Category { get; set; }

        //BelongsTo is Autohor if it is a book
        [Display(Name = "Yazarı/Yönetmeni/Eğitimci")]
        public string BelongsTo { get; set; }
        [Display(Name = "URL")]
        public string URL { get; set; }
        public ICollection<Plans> Plan { get; set; }
        public ICollection<ItemPoints> Point { get; set; }
        public ICollection<ItemComments> Comment { get; set; }
    }
}
