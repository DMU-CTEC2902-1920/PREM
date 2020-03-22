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
    }
}