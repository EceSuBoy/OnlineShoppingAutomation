using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class ToDoController : Controller
    {
        Context c = new Context();
        // GET: ToDo
        public ActionResult Index()
        {
            var deger1= c.Sellers.Count().ToString();
            ViewBag.dgr1 = deger1; 

            var deger2 = c.Products.Count().ToString();
            ViewBag.dgr2 = deger2;

            var deger3 = c.Categories.Count().ToString();
            ViewBag.dgr3 = deger3;

            var deger4= (from x in c.Sellers
                         select x.SellerCity).Distinct().Count().ToString();
            ViewBag.dgr4 = deger4;


            var Todo = c.ToDos.ToList();
            return View(Todo);
        }
    }
}