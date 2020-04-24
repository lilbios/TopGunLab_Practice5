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
    public class SuppliesController : Controller
    {
        private readonly DataManager dataManager;
        public SuppliesController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: Supplies
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var models = await dataManager.Supplies.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid id)
        {
            var model = await dataManager.Supplies.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            var plantations = await dataManager.Plantations.GetAll();
            var warehouses = await dataManager.Warehouses.GetAll();

            ViewBag.Plantations = new SelectList(plantations,"Id","Name");
            ViewBag.Warehouses = new SelectList(warehouses, "Id", "Name");
            
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(FormCollection supply)
        {

            var newSupply = new Supply()
            {
                Name = supply["Name"],
                ScheduledDate = supply["ScheduledDate"],
                ClosedDate = supply["ClosedDate"],
                WarehouseId =  new Guid(supply["Warehouse"]),
                PlantationId = new Guid(supply["Plantation"])
            };
           
                await dataManager.Supplies.Create(newSupply);
                return RedirectToAction(nameof(SuppliesController.Index));
            

            
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var model = await dataManager.Supplies.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(Supply supply)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Supplies.Update(supply);

                return RedirectToAction(nameof(SuppliesController.Index));
            }

            return View(supply);
        }


        [HttpPost]

        public async Task<ActionResult> Delete(Guid id)
        {
            var model = await dataManager.Supplies.Get(id);
            await dataManager.Supplies.Remove(model);
            return RedirectToAction(nameof(SuppliesController.Index));
        }
    }
}