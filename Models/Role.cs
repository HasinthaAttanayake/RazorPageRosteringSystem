using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageRosteringSystem.Models
{
    public class Role
    {
        [Display(Name = "Role ID")]
        public int roleID { get; set; }
        [Display(Name = "Role Name")]
        [StringLength(80, MinimumLength = 3)]
        public string name { get; set; }
        [Display(Name = "Role Description")]
        [StringLength(120, MinimumLength = 3)]
        public string description { get; set; }
        [Display(Name = "Rate of Pay ($/hr)")]
        [DataType(DataType.Currency)]
        public decimal ratehr { get; set; }

        // PK-FK Linkage
        public List<Staff> Staffers { get; set; }
    }
}
