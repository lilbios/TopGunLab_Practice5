using FlowerDelivery.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly DataManager dataManager;
        public WarehousesController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: Warehouses
        public ActionResult Index()
        {
            return View();
        }


    }
}