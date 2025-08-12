using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string BillSerialNo { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string BillItemNo { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string TaxOffice { get; set; }
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string Hour { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Deliverer { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Recipient { get; set; }
        public decimal Sum { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }

    }
}