using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string UserPassword { get; set; }        
        [Display(Name = "Address")]
        public string StreetName { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        [Display(Name = "Day you want your trash picked up")]
        public string PickupDay { get; set; }
        public IEnumerable<string> DaysOfTheWeek { get; set; }
        [Display(Name = "Removal Fee ($5 per pickup)")]
        public int removalFee { get; set; }
    }
}