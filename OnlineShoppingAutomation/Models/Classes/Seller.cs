using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string SellerName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string SellerSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string SellerCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string SellerMail { get; set; }

        public SalesLog SalesLog { get; set; }
    }
}