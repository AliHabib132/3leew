using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WPTS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="This filed is required")]
        [DisplayName("Emp. No.")]
        [Column(TypeName = "int")]
        public int? EmployeeNumber { get; set; }

        [DisplayName("Full Name")]
        [Column(TypeName ="varchar(250)")]
        public string FullName { get; set; }

        [DisplayName("Employee Trade")]
        [Column(TypeName ="varchar(100)")]
        public string Position { get; set; }
        
    }
}
