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
        [StringLength(30, ErrorMessage ="You can enter max 30 characters.")]
        public string SellerName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required(ErrorMessage ="You must fill this field.")]
        public string SellerSurname { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string SellerCity { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string SellerMail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string SellerPassword { get; set; }
        public bool Status { get; set; }
        public ICollection<SalesLog> SalesLogs { get; set; }
    }
}