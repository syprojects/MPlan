using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MPlan.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public Plans Plans { get; set; }
        public Plans CompletedPlans { get; set; }
        public Items CompletedItems { get; set; }
        public Users MyFriends { get; set; }


    }
}
