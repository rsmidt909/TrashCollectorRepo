using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            string SignedInUser = User.Identity.GetUserId();
            var AreYouACustomer = db.Customers.Where(s => s.ApplicationId == SignedInUser).FirstOrDefault();
            //var AreYouAEmployee = db.Employees.Where(s=>s.ApplicationId==SignedInUser).SingleOrDefault();
            if (AreYouACustomer != default(Customer))
            {                
                return RedirectToAction("Index", "Customer", "CustomerHome");
            }
            //if (AreYouACustomer != default(Employee))
            //{
            //    return RedirectToAction("Home", "Employee", "EmployeeHome");
            //}
           
                return View(); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}