using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MPlan.Models
{
    public class Points
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Point { get; set; }
        public Users Voter { get; set; }
    }

    public class ItemPoints : Points
    {
        public int ItemId { get; set; }
    }

    public class PlanPoints : Points
    {
        public int PlanId { get; set; }
    }
}
