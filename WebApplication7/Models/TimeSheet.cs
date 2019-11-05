using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;


namespace WebApplication7.Models
{
    public class TimeSheet
    {
        public int ID { get; set; }
        [Display(Name = "User")]
        public string UserID { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }

        [Display(Name = "Deliver to")]
        public string DeliveryName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public int? ProjectID { get; set; }
        public virtual Project Project { get; set; }





    }
}