using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public bool Status { get; set; }
        public string ProductImage { get; set; }
        public Catagory Catagory { get; set; }
        public SalesLog SalesLog { get; set; }


    }
}