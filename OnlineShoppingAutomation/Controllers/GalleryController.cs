using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class GalleryController : Controller
    {
        Context c = new Context();
        // GET: Gallery
        public ActionResult Index()
        {
            var degerler = c.Products.ToList();
            return View(degerler);
        }
    }
}