using FlowerDelivery.DAL;
using FlowerDelivery.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var models = await dataManager.Warehouses.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid id)
        {
            var model = await dataManager.Warehouses.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(Warehouse warehouse)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Warehouses.Create(warehouse);
                return RedirectToAction(nameof(WarehouseFlowersController.Index));
            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var model = await dataManager.Warehouses.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(Warehouse PlantationFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Warehouses.Update(PlantationFlower);

                return RedirectToAction(nameof(WarehouseFlowersController.Index));
            }

            return View(PlantationFlower);
        }


        [HttpPost]

        public async Task<ActionResult> Delete(Guid id)
        {
            var model = await dataManager.Warehouses.Get(id);
            await dataManager.Warehouses.Remove(model);
            return RedirectToAction(nameof(WarehouseFlowersController.Index));
        }

    }
}