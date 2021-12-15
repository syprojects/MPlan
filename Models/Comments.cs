using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MPlan.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public string Comment { get; set; }
        public Users Owner { get; set; }

    }

    public class ItemComments : Comments
    {
        public int ItemId { get; set; }
    }

    public class PlanComments : Comments
    {
        public int PlanId { get; set; }
    }
}
