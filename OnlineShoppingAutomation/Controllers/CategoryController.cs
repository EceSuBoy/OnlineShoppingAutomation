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
            var degerler=c.Categorys.ToList();
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
            c.Categorys.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var cate = c.Categorys.Find(id);
            c.Categorys.Remove(cate);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var cate = c.Categorys.Find(id);
            return View(cate);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category k)
        {
            var cate=c.Categorys.Find(k.CatagoryId);
            cate.CatagoryName = k.CatagoryName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}