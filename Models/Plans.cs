using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MPlan.Models
{
    public enum period
    {
        [Display(Name = "Yıllık")]
        Yearly,
        [Display(Name = "Aylık")]
        Monthly,
        [Display(Name = "Haftalık")]
        Weekly,
        [Display(Name = "Günlük")]
        Daily
    }

    //Usage Type
    public enum UType
    {
        [Display(Name = "Şablon")]
        Template,
        [Display(Name = "Kişiye Özel")]
        Private,
        [Display(Name = "Arkadaşlar")]
        Friends,
        [Display(Name = "Genele Açık")]
        Public

    }
    public class Plans
    {
        [Key]
        public int Id { get; set; }
        // PlanType: Yearly, monthly, daily, weekly
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Plan Tipi")]
        public period PlanType { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Bitiş Tarihi")]
        public DateTime EndDate
        {
            get { return EndDate; }
            set
            {
                EndDate = value;
                switch (PlanType)
                {
                    case period.Daily:
                        if ((value - StartDate).TotalDays < 1)
                        {

                            EndDate = StartDate.AddDays(1);
                        }
                        break;
                    case period.Weekly:
                        if ((value - StartDate).TotalDays < 7)
                        {

                            EndDate = StartDate.AddDays(7);
                        }
                        break;
                    case period.Monthly:
                        if ((value - StartDate).TotalDays < 30)
                        {

                            EndDate = StartDate.AddDays(30);
                        }
                        break;

                    case period.Yearly:
                        if ((value - StartDate).TotalDays < 365)
                        {

                            EndDate = StartDate.AddDays(365);
                        }
                        break;
                    default:
                        EndDate = value;
                        break;

                }

                EndDate = value;
            }
        }

        [Range(0, 100,ErrorMessage ="0 ile 100 arasında olmalı")]
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Tamamlanma Yüzdesi")]
  
        //Completed Percent
        public int CPercent { get; set; } = 0;

        // UsageType         Template, Private, Friends, Public
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Görünürlük")]
        public UType UsageType { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public ICollection<PlanPoints> Point { get; set; }
        public ICollection<PlanComments> Comment { get; set; }


    }
}
