using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Flowers()
        {
            return View();
        }

        [HttpGet]
        public  ActionResult Supplies() {
            return View();
        }

        [HttpGet]
        public ActionResult Warehouses() {
            return View();
        }

        [HttpGet]
        public ActionResult Plantations() {
            return View();

        }


    }
}