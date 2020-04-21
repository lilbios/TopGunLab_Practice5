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
    public class PlantationsController : Controller
    {
        private readonly DataManager dataManager;
        public PlantationsController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: Plantations
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var models = await dataManager.Plantations.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid id)
        {
            var model = await dataManager.Plantations.Get(id);

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

        public async Task<ActionResult> Create(Plantation plantation)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Plantations.Create(plantation);
                //return RedirectToAction("Details", new { id = Plantation.Id });
            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var model = await dataManager.Plantations.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]

        public async Task<ActionResult> Edit(Plantation plantation)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Plantations.Update(plantation);

                //return RedirectToAction("Details", new { id = Plantation.Id });
            }

            return View(plantation);
        }


        [HttpPost]

        public async Task<ActionResult> Delete(Guid id)
        {
            var model = await dataManager.Plantations.Get(id);
            await dataManager.Plantations.Remove(model);
            return RedirectToAction(nameof(PlantationsController.Index));
        }
    }
}