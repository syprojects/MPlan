using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public Plans MyPlans { get; set; }
        public Plans CompletedPlans { get; set; }
        public Items CompletedItems { get; set; }
        public Users MyFriends { get; set; }


    }
}
