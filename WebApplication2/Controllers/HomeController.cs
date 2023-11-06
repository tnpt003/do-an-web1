using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Cart()
        {
            ViewBag.Message = "Your cart page.";

            return View();
        }
        public ActionResult Sign_in()
        {
            ViewBag.Message = "Your sign in page.";

            return View();
        }
        public ActionResult Product_Detail()
        {
            ViewBag.Message = "Your cart page.";

            return View();
        }
    }
}