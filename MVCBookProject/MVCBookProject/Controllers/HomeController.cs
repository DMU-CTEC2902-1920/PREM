using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBookProject.Controllers
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

        public ActionResult Addbook()
        {
            ViewBag.Message = "Your add book page.";

            return View();
        }

        public ActionResult BookLink()
        {
            ViewBag.Message = "Your add book page.";

            return View();
        }
    }
}