using FlowerDelivery.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class SupplyFlowersController : Controller
    {
        private readonly DataManager dataManager;
        public SupplyFlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: SupplyFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}