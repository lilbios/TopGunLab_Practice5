using FlowerDelivery.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class SuppliesController : Controller
    {
        private readonly DataManager dataManager;
        public SuppliesController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: Supplies
        public ActionResult Index()
        {
            return View();
        }
    }
}