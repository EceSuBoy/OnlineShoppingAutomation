using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class BillController : Controller
    {
        Context c = new Context();
        // GET: Bill
        public ActionResult Index()
        {
            var liste = c.Bills.ToList();
            return View(liste);
        }
        public ActionResult AddBill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBill(Bill b)
        {
            c.Bills.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateBill(int id)
        {
            var bill = c.Bills.Find(id);
            return View("UpdateBill", bill);
        }
        [HttpPost]
        public ActionResult UpdateBill(Bill b)
        {
            var bill = c.Bills.Find(b.BillId);
            bill.BillSerialNo = b.BillSerialNo;
            bill.BillItemNo = b.BillItemNo;
            bill.Date = b.Date;
            bill.TaxOffice = b.TaxOffice;
            bill.Hour = b.Hour;
            bill.Deliverer = b.Deliverer;
            bill.Recipient = b.Recipient;
            bill.Sum = b.Sum;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailBill(int id)
        {
            var bill = c.InvoiceItems.Where(x => x.BillId == id).ToList();
            return View(bill);
        }
        public ActionResult AddInvoice()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoice(InvoiceItem p)
        {
            c.InvoiceItems.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}