using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingAutomation.Models.Classes;

namespace OnlineShoppingAutomation.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Departments.Where(x => x.State == true).ToList();
            return View(degerler);
        }

        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department d)
        {
            c.Departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDepartment(int id)
        {
            var dep = c.Departments.Find(id);
            dep.State = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateDepartment(int id)
        {
            var dpt = c.Departments.Find(id);
            return View("UpdateDepartment", dpt);
        }
        [HttpPost]
        public ActionResult UpdateDepartment(Department p)
        {
            var dept = c.Departments.Find(p.DepartmentId);
            dept.DepartmentName = p.DepartmentName; 
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DetailDepartment(int id)
        {
            var degerler=c.Employees.Where(x=>x.Departmentid == id).ToList();
            var dpt= c.Departments.Where(x=>x.DepartmentId == id).Select(y=>y.DepartmentName).FirstOrDefault();
            ViewBag.d=dpt;
            return View(degerler);
        }
        public ActionResult EmployeeSaleDepartment(int id)
        {
            var degerler= c.SalesLogs.Where(x=>x.Employeeid == id).ToList();
            var per = c.Employees.Where(x=>x.EmployeeId == id).Select(y=>y.EmployeeName +" " + y.EmployeeSurname).FirstOrDefault();
            ViewBag.dpers = per;
            return View(degerler);
        }

    }
}