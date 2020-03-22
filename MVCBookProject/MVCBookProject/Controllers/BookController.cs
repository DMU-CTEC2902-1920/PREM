using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCBookProject.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
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
            ViewBag.Content = "This book is written by Howard Bryant";

            return View();
        }

        public ActionResult TheMambaMentality()
        {


            ViewBag.Title = "TheMambaMentality";
            ViewBag.Author = "Kobe Bryant";
            ViewBag.Content = "This book is written by Kobe Bryant";

            return View();
        }
    }
}