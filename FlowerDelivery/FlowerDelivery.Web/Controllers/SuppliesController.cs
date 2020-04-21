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
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(Supply Supply)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Supplies.Create(Supply);
                //return RedirectToAction("Details", new { id = Supply.Id });
            }

            return View();
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

                //return RedirectToAction("Details", n`ew { id = Supply.Id });
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