using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }
        public string SellerCity { get; set; }
        public string SellerMail { get; set; }
    }
}