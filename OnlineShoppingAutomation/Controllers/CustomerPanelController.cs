using OnlineShoppingAutomation.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingAutomation.Controllers
{
    public class CustomerPanelController : Controller
    {
        Context c = new Context();
        // GET: ClientPanel
        [Authorize]       
        public ActionResult Index()
        {
            var mail = (string)Session["SellerMail"];
            var degerler = c.Sellers.FirstOrDefault(x => x.SellerMail == mail);
            ViewBag.m= mail;
            return View(degerler);
        }
        public ActionResult CustomerOrderList()
        {
            var mail = (string)Session["SellerMail"];
            var id = c.Sellers.Where(x => x.SellerMail == mail.ToString()).Select(y => y.SellerId).FirstOrDefault();
            var degerler=c.SalesLogs.Where(x=>x.Sellerid == id).ToList();
            return View(degerler);
        }
    }
}