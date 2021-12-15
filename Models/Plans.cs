using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MPlan.Models
{
    public enum period
    {
        Yearly, 
        Monthly, 
        Weekly,
        Daily
    }

    //Usage Type
    public enum UType
    {
        Template,
        Private,
        Friends,
        Public
        
    }
    public class Plans
    {
        [Key]
        public int Id { get; set; }
        // PlanType: Yearly, monthly, daily, weekly
        public period PlanType { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Range(0, 100)]
        //Completed Percent
        public int CPercent { get; set; } = 0;

        // UsageType         Template, Private, Friends, Public
        public UType UsageType { get; set; }
        public ICollection<PlanPoints> Point { get; set; }
        public ICollection<PlanComments> Comment { get; set; }


    }
}
