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
        public ICollection<Plans> MyPlans { get; set; }
        public ICollection<Items> MyItems { get; set; }
        public ICollection<Users> MyFriends { get; set; }



    }
}
