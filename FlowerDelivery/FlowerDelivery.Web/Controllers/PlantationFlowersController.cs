using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class PlantationFlowersController : Controller
    {
        // GET: PlantationsFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}