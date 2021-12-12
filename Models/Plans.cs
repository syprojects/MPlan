using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPlan.Models
{
    public class Plans
    {
        // Type: Yearly, monthly, daily, weekly
        public string Type { get; set; }
        public DateTime MyStartDate { get; set; }
        public DateTime MyEndTime { get; set; }

        // UsageType 0 = Template ; 1 = User
        public int UsageType { get; set; }
        public Points MyPoint { get; set; }
        public Comments MyComment { get; set; }


    }
}
