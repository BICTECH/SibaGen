using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarWebApp.Controllers
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

        public ActionResult products()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult frequently_asked_questions()
        {
            return View();
        }

        public ActionResult payment_details()
        {
            return View();
        }

        public ActionResult buy_new_policy()
        {
            return View();
        }

        public ActionResult account_profile()
        {
            return View();
        }
    }
}