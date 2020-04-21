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
    public class SupplyFlowersController : Controller
    {
        private readonly DataManager dataManager;
        public SupplyFlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: SupplyFlowers
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var models = await dataManager.SupplyFlowers.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid idPlantation, Guid idFlower)
        {
            var model = await dataManager.SupplyFlowers.Get(idPlantation, idFlower);

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

        public async Task<ActionResult> Create(SupplyFlower supplyFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.SupplyFlowers.Create(supplyFlower);
                //return RedirectToAction("Details", new { id = PlantationFlower.Id });
            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid idSupply,Guid idFlower)
        {
            var model = await dataManager.SupplyFlowers.Get(idSupply,idFlower);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(SupplyFlower PlantationFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.SupplyFlowers.Update(PlantationFlower);

                //return RedirectToAction("Details", new { id = PlantationFlower.Id });
            }

            return View(PlantationFlower);
        }


        [HttpPost]

        public async Task<ActionResult> Delete(Guid idSupply, Guid idFlower)
        {
            var model = await dataManager.SupplyFlowers.Get(idSupply, idFlower);
            await dataManager.SupplyFlowers.Remove(model);
            return RedirectToAction(nameof(PlantationFlowersController.Index));
        }
    }
}