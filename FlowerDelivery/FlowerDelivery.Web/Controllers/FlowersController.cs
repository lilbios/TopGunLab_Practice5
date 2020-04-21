using FlowerDelivery.DAL;
using FlowerDelivery.DTO.Entities;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FlowerDelivery.Web.Controllers
{
    public class FlowersController : Controller
    {
        private readonly DataManager dataManager;

        public FlowersController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        // GET: Flowers
        [HttpGet]
        public async  Task<ActionResult> Index()
        {
            var models = await dataManager.Flowers.GetAll();

            return View(models);
        }
        [HttpGet]
        public async Task<ActionResult> Info(Guid id)
        {
            var model = await dataManager.Flowers.Get(id);

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
        
        public async Task<ActionResult> Create(Flower flower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Flowers.Create(flower);
                //return RedirectToAction("Details", new { id = flower.Id });
            }

            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var model = await dataManager.Flowers.Get(id);

            if (model == null)
            {
                return HttpNotFound();
            }

            return View(model);
        }

        [HttpPost]
        
        public async Task<ActionResult> Edit(Flower flower)
        {
            if (ModelState.IsValid)
            {
                await dataManager.Flowers.Update(flower);

                //return RedirectToAction("Details", n`ew { id = flower.Id });
            }

            return View(flower);
        }
       

        [HttpPost]
        
        public async Task<ActionResult> Delete(Guid id)
        {
            var model = await dataManager.Flowers.Get(id);
            await dataManager.Flowers.Remove(model);
            return RedirectToAction(nameof(FlowersController.Index));
        }

    }
}