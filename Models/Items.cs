using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public class Items
    {
        //MyCategory is Book, movie, training, etc.
        public string MyCategory { get; set; }
        public string MyName { get; set; }
        //BelongsTo is Autohor if it is a book
        public string BelongsTo { get; set; }
        public string MyURL { get; set; }
        public Points MyPoint { get; set; }
        public Comments MyCommment { get; set; }
    }
}
