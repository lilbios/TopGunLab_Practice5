using FlowerDelivery.DAL;
using FlowerDelivery.SL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class SupplyFlowersController : Controller
    {
        private readonly ServiceManager serviceManager;
        public SupplyFlowersController(DataManager dataManager)
        {
            serviceManager = new ServiceManager(dataManager);
        }
        // GET: SupplyFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}