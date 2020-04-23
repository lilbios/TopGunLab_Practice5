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
    public class WarehouseFlowersController : Controller
    {
        private readonly DataManager dataManager;
        public WarehouseFlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: WarehouseFlowers
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var models = await dataManager.WarehouseFlowers.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid idPlantation, Guid idFlower)
        {
            var model = await dataManager.WarehouseFlowers.Get(idPlantation, idFlower);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }
        [HttpGet]
        public async Task< ActionResult> Create()
        {
            var warehouse = await dataManager.Warehouses.GetAll();
            var flowers = await dataManager.Flowers.GetAll();
            ViewBag.Warehouse = new SelectList(warehouse, "Id", "Name");
            ViewBag.Flowers = new SelectList(flowers, "Id", "Name");
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(WarehouseFlower warehouseFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.WarehouseFlowers.Create(warehouseFlower);
                return RedirectToAction(nameof(WarehouseFlowersController.Index));
            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid idWarehouse, Guid idFlower)
        {
            var model = await dataManager.WarehouseFlowers.Get(idWarehouse, idFlower);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(WarehouseFlower PlantationFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.WarehouseFlowers.Update(PlantationFlower);

                return RedirectToAction(nameof(WarehouseFlowersController.Index));
            }

            return View(PlantationFlower);
        }


        [HttpPost]

        public async Task<ActionResult> Delete(Guid idWarehouse, Guid idFlower)
        {
            var model = await dataManager.WarehouseFlowers.Get(idWarehouse, idFlower);
            await dataManager.WarehouseFlowers.Remove(model);
            return RedirectToAction(nameof(WarehouseFlowersController.Index));
        }
    }
}