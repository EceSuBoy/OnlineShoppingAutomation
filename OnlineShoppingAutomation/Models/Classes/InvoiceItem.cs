using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(150)]
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SumPrice { get; set; }
        public Bill Bill { get; set; }
    }
}