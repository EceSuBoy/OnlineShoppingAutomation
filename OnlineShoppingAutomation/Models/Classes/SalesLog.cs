using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class SalesLog
    {
        [Key]
        public int SalesId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalSum { get; set; }
        public int Productid { get; set; }
        public int Sellerid { get; set; }
        public int Employeeid { get; set; }

        public virtual Product Product { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual Employee Employee { get; set; }

    }
}