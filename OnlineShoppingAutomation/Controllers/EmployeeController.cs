using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Employees.ToList();
            return View(degerler);
        }
        public ActionResult EmployeeAdd()
        {
            List<SelectListItem> deger1 = (from x in c.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentName,
                                               Value = x.DepartmentId.ToString()
                                           }).ToList();

            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeAdd(Employee p)
        {
            c.Employees.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateEmployee(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentName,
                                               Value = x.DepartmentId.ToString()
                                           }).ToList();

            ViewBag.dgr1 = deger1;
            var prs = c.Employees.Find(id);
            return View("UpdateEmployee", prs);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee p)
        {
            var emp = c.Employees.Find(p.EmployeeId);
            emp.EmployeeName = p.EmployeeName;
            emp.EmployeeSurname = p.EmployeeSurname;
            emp.EmployeeImage = p.EmployeeImage;
            emp.Departmentid = p.Departmentid;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}