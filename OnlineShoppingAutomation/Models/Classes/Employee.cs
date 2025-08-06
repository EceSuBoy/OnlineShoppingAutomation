using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeImage { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(300)]

        public ICollection<SalesLog> SalesLogs { get; set; }
        public Department Department { get; set; }
    }
}