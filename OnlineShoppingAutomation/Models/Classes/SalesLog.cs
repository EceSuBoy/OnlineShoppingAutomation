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
        //Product
        //Seller
        //Employee
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalSum { get; set; }
    }
}