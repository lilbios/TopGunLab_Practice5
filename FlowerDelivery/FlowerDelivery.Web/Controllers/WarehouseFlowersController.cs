using FlowerDelivery.DAL;
using FlowerDelivery.SL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class WarehouseFlowersController : Controller
    {
        private readonly ServiceManager serviceManager;
        public WarehouseFlowersController(DataManager dataManager)
        {
            serviceManager = new ServiceManager(dataManager);
        }
        // GET: WarehouseFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}