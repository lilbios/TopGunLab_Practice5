using FlowerDelivery.DAL;
using FlowerDelivery.SL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class PlantationFlowersController : Controller
    {
        private readonly ServiceManager serviceManager;
        public PlantationFlowersController(DataManager dataManager)
        {
            serviceManager = new ServiceManager(dataManager);
        }
        // GET: PlantationsFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}