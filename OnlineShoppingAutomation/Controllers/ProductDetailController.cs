using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class ProductDetailController : Controller
    {
        Context c = new Context();
        // GET: ProductDetail
        public ActionResult Index()
        {
            ValueClass cs = new ValueClass();
            //var degerler = c.Products.Where(x=>x.ProductId==1).ToList();
            cs.Deger1 = c.Products.Where(x=>x.ProductId==1).ToList();
            cs.Deger2 = c.Details.Where(y => y.DetailID == 1).ToList();
            return View(cs);
        }
    }
}