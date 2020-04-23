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
    public class PlantationFlowersController : Controller
    {
        private readonly DataManager dataManager;
        public PlantationFlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: PlantationsFlowers
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var models = await dataManager.PlantationFlowers.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid idPlantation, Guid idFlower)
        {
            var model = await dataManager.PlantationFlowers.Get(idPlantation, idFlower);

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

        public async Task<ActionResult> Create(PlantationFlower plantationFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.PlantationFlowers.Create(plantationFlower);
                return RedirectToAction(nameof(PlantationFlowersController.Index));
            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var model = await dataManager.PlantationFlowers.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(PlantationFlower PlantationFlower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.PlantationFlowers.Update(PlantationFlower);

                return RedirectToAction(nameof(PlantationFlowersController.Index));
            }

            return View(PlantationFlower);
        }


        [HttpPost]

        public async Task<ActionResult> Delete(Guid idPlantation, Guid idFlower)
        {
            var model = await dataManager.PlantationFlowers.Get(idPlantation, idFlower);
            await dataManager.PlantationFlowers.Remove(model);
            return RedirectToAction(nameof(PlantationFlowersController.Index));
        }
    }
}