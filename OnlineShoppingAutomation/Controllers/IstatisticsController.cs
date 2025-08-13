using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class IstatisticsController : Controller
    {
        Context c = new Context();
        // GET: Istatistics
        public ActionResult Index()
        {
            var deger1 = c.Sellers.Count().ToString();
            ViewBag.d1 = deger1;

            var deger2 = c.Products.Count().ToString();
            ViewBag.d2 = deger2;

            var deger3 = c.Employees.Count().ToString();
            ViewBag.d3 = deger3;

            var deger4 = c.Categories.Count().ToString();
            ViewBag.d4 = deger4;

            var deger5 = c.Products.Sum(x => x.Stock).ToString();
            ViewBag.d5 = deger5;

            var deger6 = (from x in c.Products select x.Brand).Distinct().Count().ToString();
            ViewBag.d6 = deger6;

            var deger7 = c.Products.Count(x => x.Stock <= 20).ToString();
            ViewBag.d7 = deger7;

            var deger8 = (from x in c.Products orderby x.SellPrice descending select x.ProductName).FirstOrDefault();
            ViewBag.d8 = deger8;

            var deger9 = (from x in c.Products orderby x.SellPrice ascending select x.ProductName).FirstOrDefault();
            ViewBag.d9 = deger9;

            int computerCategoryId = c.Categories
    .Where(ca => ca.CategoryName == "Computer")
    .Select(ca => ca.CategoryId)
    .FirstOrDefault();

            var deger10 = c.Products
                .Count(p => p.Categoryid == computerCategoryId)
                .ToString();

            ViewBag.d10 = deger10;



            int phoneCategoryId = c.Categories
   .Where(ca => ca.CategoryName == "Phone")
   .Select(ca => ca.CategoryId)
   .FirstOrDefault();

            var deger11 = c.Products
                .Count(p => p.Categoryid == phoneCategoryId)
                .ToString();

            ViewBag.d11 = deger11;

            var deger12 = c.Products
    .GroupBy(p => p.Brand)
    .OrderByDescending(g => g.Count())
    .Select(g => g.Key)
    .FirstOrDefault();

            ViewBag.d12 = deger12;

            var deger13 = c.Products.Where(u=>u.ProductId==(c.SalesLogs.GroupBy(x => x.Productid).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault())).Select(k=>k.ProductName).FirstOrDefault();
            ViewBag.d13 = deger13;

            var deger14 = c.SalesLogs.Sum(x => x.TotalSum).ToString();
            ViewBag.d14 = deger14;

            var deger15 = c.SalesLogs.Count(x => x.Date == DateTime.Today).ToString();
            ViewBag.d15 = deger15;

            var deger16 = c.SalesLogs
    .Where(x => x.Date == DateTime.Today)
    .Select(x => x.TotalSum)
    .DefaultIfEmpty(0) // Prevents exception if no rows match
    .Sum()
    .ToString();

            ViewBag.d16 = deger16;

            return View();
        }
        public ActionResult SimpleTables()
        {
            var sorgu = from x in c.Sellers group x by x.SellerCity into g
                        select new GroupClass
                        {
                            City = g.Key,
                            Count = g.Count()
                        };
            return View(sorgu.ToList());
        }
    }
}