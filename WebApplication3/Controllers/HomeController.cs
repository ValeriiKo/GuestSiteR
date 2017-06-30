using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int h = DateTime.Now.Hour;
            ViewBag.Hello = h < 12 ? "Good morning, " : "Good afternoon, ";
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}