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
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string name { get; set;}
        [Display(Name = "Address")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string address { get; set; }
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime dateOfBirth { get; set; }
        [Display(Name = "Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9]+[a-zA-Z0-9.-]+[a-zA-Z0-9]+.[a-z]{0,4}$"), StringLength(80)]
        [Required]
        public string email { get; set; }
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^([+]\d{2})?\d{10}$"), StringLength(80)]
        [Required]
        public string mob { get; set; }

        // foreign key relationship
        [Display(Name = "Role ID")]
        public int? roleID { get; set; }
        [ForeignKey("roleID")]
        public Role Role { get; set; }
    }
}
