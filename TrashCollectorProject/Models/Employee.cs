using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string UserPassword { get; set; }
        [Display(Name = "Address")]
        public string City { get; set; }
        public int Zip { get; set; }
        public IEnumerable<string> DaysOfTheWeek { get; set; }
        
    }
}