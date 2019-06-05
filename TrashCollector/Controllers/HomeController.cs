using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (this.User.IsInRole("TrashGiveAwayer"))
            {
                return RedirectToAction("Details", "Customer", "CustomerHome");
            }
            if (this.User.IsInRole("TrashGoblin"))
            {
                return RedirectToAction("Home", "Employee", "EmployeeHome");
            }
           
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