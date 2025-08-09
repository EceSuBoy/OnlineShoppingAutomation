using OnlineShoppingAutomation.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingAutomation.Controllers
{
    public class SellerController : Controller
    {
        Context c = new Context();
        // GET: Seller
        public ActionResult Index()
        {
            var degerler = c.Sellers.Where(x => x.Status == true).ToList();
            return View(degerler);
        }

        public ActionResult AddSeller()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSeller(Seller p)
        {
            p.Status = true;
            c.Sellers.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSeller(int id)
        {
            var sel = c.Sellers.Find(id);
            sel.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSeller(int id)
        {
            var sel = c.Sellers.Find(id);
            return View("UpdateSeller", sel);
        }
        [HttpPost]
        public ActionResult UpdateSeller(Seller p)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateSeller");
            }
            var sel = c.Sellers.Find(p.SellerId);
            sel.SellerName = p.SellerName;
            sel.SellerSurname = p.SellerSurname;
            sel.SellerCity = p.SellerCity;
            sel.SellerMail = p.SellerMail;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ClientSales(int id)
        {
            var degerler = c.SalesLogs.Where(x => x.Sellerid == id).ToList();
            var cr = c.Sellers.Where(x => x.SellerId == id).Select(y => y.SellerName + " " + y.SellerSurname).FirstOrDefault();
            ViewBag.seller = cr;
            return View(degerler);
        }
    }
}