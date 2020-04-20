using FlowerDelivery.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class PlantationFlowersController : Controller
    {
        private readonly DataManager dataManager;
        public PlantationFlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: PlantationsFlowers
        public ActionResult Index()
        {
            return View();
        }
    }
}