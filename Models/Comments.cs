using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public class Comments
    {
        public string MyComment { get; set; }
        public Users Commenter { get; set; }
    }
}
