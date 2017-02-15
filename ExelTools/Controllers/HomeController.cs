using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExelTools.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult Customers()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult Suppliers()
        {
            return View();
        }


        public ActionResult UpdateWebProducts()
        {
            //            var data = context.WebProducts.ToList();
            ViewBag.Title = "Activate on Inflow";

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