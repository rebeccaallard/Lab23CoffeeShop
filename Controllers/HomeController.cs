using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23CoffeeShop.Models;

namespace Lab23CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "All about The Lab Coffee Shop";

            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Message = "Cool stuff for sale...";

            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Register for our coffee club!";

            return View();
        }

        public ActionResult Success(User u)
        {
            ViewBag.FirstName = "Welcome " + u.FirstName + " " + u.LastName;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact us...";

            return View();
        }
    }
}