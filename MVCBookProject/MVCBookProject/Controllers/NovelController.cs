using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBookProject.Controllers
{
    public class NovelController : Controller
    {
        // GET: Novel
        public ActionResult BenSimmons()
        {
            ViewBag.Message = "Ben simmons";
            return View();
        }

        public ActionResult Legends()
        {
            ViewBag.Message = "Legends";
            return View();
        }

        public ActionResult MambaMentality()
        {
            ViewBag.Message = "MambaMentality";
            return View();
        }
    }


}