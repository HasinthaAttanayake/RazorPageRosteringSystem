using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageRosteringSystem.Models
{
    public class Staff
    {
        [Display(Name = "Staff ID")]
        public int staffID { get; set; }
        [Display(Name = "Full Name")]
        public string name { get; set;}
        [Display(Name = "Address")]
        public string address { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        [Display(Name = "Email Address")]
        public string email { get; set; }
        [Display(Name = "Mobile Number")]
        public string mob { get; set; }

    }
}
