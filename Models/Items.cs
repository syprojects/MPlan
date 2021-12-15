using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        //MyCategory is Book, movie, training, etc.
        [Required]
        public string Name { get; set; }

        [Display(Name ="Kategori")]
        public string Category { get; set; }

        // UsageType         Template, Private, Friends, Public
        public UType UsageType { get; set; }

        //BelongsTo is Autohor if it is a book
        public string BelongsTo { get; set; }
        public string URL { get; set; }
        public ICollection<ItemPoints> Point { get; set; }
        public ICollection<ItemComments> Comment { get; set; }
    }
}
