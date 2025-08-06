using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal SumPrice { get; set; }
    }
}