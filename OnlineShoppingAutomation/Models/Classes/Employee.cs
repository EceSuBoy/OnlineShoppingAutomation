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
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string EmployeeSurname { get; set; }
       
        public string EmployeeImage { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(300)]

        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<SalesLog> SalesLogs { get; set; }
        public int Departmentid { get; set; }
        public virtual Department Department { get; set; }
    }
}