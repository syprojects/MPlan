using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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

        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Plan Adı")]
        public string Name { get; set; }
        // PlanType: Yearly, monthly, daily, weekly
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Plan Tipi")]
        public period PlanType { get; set; }
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [Range(0, 100,ErrorMessage ="0 ile 100 arasında olmalı")]
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Tamamlanma Yüzdesi")]
  
        //Completed Percent
        public int CPercent { get; set; }

        // UsageType         Template, Private, Friends, Public
        [Required(ErrorMessage = "Bu alan zorunlu")]
        [Display(Name = "Görünürlük")]
        public UType UsageType { get; set; }
        [Display(Name = "Görev/Nesne")]
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public ICollection<PlanPoints> Point { get; set; }
        public ICollection<PlanComments> Comment { get; set; }

        public ICollection<Items> Items1 { get; set; }
    }
}
