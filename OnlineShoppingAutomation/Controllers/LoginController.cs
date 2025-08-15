using OnlineShoppingAutomation.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShoppingAutomation.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
       Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialCustomerSignUp()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialCustomerSignUp(Seller p)
        {
            p.Status = true;
            c.Sellers.Add(p);           
            c.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public ActionResult CustomerLogin1()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult CustomerLogin1(Seller p)
        {
            var bilgiler = c.Sellers.FirstOrDefault(x=>x.SellerMail == p.SellerMail && x.SellerPassword == p.SellerPassword);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.SellerMail, false);
                Session["SellerMail"] = bilgiler.SellerMail;
                Session["SellerId"] = bilgiler.SellerId;
                return RedirectToAction("Index", "CustomerPanel");
            }
            else
            {
                ViewBag.Error = "Invalid email or password.";
                return RedirectToAction("Index", "Login");
            }
        }
    }
}