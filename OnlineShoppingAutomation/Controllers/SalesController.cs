using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class SalesController : Controller
    {
        Context c = new Context();
        // GET: Sales
        public ActionResult Index()
        {
            var degerler = c.SalesLogs.ToList();
            return View(degerler);
        }
        public ActionResult AddSales()
        {
            List<SelectListItem> deger1 = (from x in c.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ProductName,
                                               Value = x.ProductId.ToString()
                                           }).ToList();

            List<SelectListItem> deger2 = (from x in c.Sellers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.SellerName + " " + x.SellerSurname,
                                               Value = x.SellerId.ToString()
                                           }).ToList();
            List<SelectListItem> deger3 = (from x in c.Employees.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.EmployeeName + " " + x.EmployeeSurname,
                                               Value = x.EmployeeId.ToString()
                                           }).ToList();

            ViewBag.dgr3 = deger3;
            ViewBag.dgr2 = deger2;
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult AddSales(SalesLog s)
        {
            s.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.SalesLogs.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}