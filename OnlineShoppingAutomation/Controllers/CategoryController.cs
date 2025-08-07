using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();
        // GET: Category
        public ActionResult Index()
        {
            var degerler=c.Categories.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category k)
        {
            c.Categories.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var cate = c.Categories.Find(id);
            c.Categories.Remove(cate);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var cate = c.Categories.Find(id);
            return View(cate);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category k)
        {
            var cate=c.Categories.Find(k.CategoryId);
            cate.CategoryName = k.CategoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}