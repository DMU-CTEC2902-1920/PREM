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
            ViewBag.Title = "Ben Simmons";
            ViewBag.Author = "Ben Simmons";
            ViewBag.Content = "This book is written by Ben Simmons";
            return View();
        }

        public ActionResult Legends()
        {
            ViewBag.Title = "Legends";
            ViewBag.Author = "Howard Bryant";
            return View();
        }

        public ActionResult MambaMentality()
        {
            ViewBag.Title = "The Mamba Mentality";
            ViewBag.Author = "Kobe Bryant";
            return View();
        }
    }


}