using FlowerDelivery.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class PlantationsController : Controller
    {
        private readonly DataManager dataManager;
        public PlantationsController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: Plantations
        public ActionResult Index()
        {
            return View();
        }
    }
}