using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();
        // GET: Product
        public ActionResult Index()
        {
            var urunler = c.Products.Where(x=>x.Status==true).ToList();
            return View(urunler);
        }
        public ActionResult AddProduct()
        {
            List<SelectListItem> deger1 = (from x in c.Categories.ToList() select new SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryId.ToString()
            }).ToList();
            
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)
        {
            var deger = c.Products.Find(id);
            deger.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
    
}