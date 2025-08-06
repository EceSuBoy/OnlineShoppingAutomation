using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingAutomation.Models.Classes
{
    public class Bill
    {
        public int BillId { get; set; }
        public char BillSerialNo { get; set; }
        public string BillItemNo { get; set; }
        public DateTime Date { get; set; }
        public string TaxOffice { get; set; }
        public DateTime Hour { get; set; }
        public string Deliverer { get; set; }
        public string Recipient { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }

    }
}