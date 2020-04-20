using FlowerDelivery.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class WarehouseFlowersController : Controller
    {
        private readonly DataManager dataManager;
        public WarehouseFlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: WarehouseFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}