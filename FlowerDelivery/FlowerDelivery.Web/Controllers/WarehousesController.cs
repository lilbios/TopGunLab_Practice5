﻿using FlowerDelivery.DAL;
using FlowerDelivery.SL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class WarehousesController : Controller
    {
        private readonly ServiceManager serviceManager;
        public WarehousesController(DataManager dataManager)
        {
            serviceManager = new ServiceManager(dataManager);
        }
        // GET: Warehouses
        public ActionResult Index()
        {
            return View();
        }


    }
}