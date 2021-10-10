using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageRosteringSystem.Models
{
    public class Staff
    {
        public int staffID { get; set; }
        public string name { get; set;} 
        public string address { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateOfBirth { get; set; }
        public string email { get; set; }
        public string mob { get; set; }

    }
}
