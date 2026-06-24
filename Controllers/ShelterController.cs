using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FureverHome.Services;

namespace FureverHome.Controllers
{
    public class ShelterController : Controller
    {
        private readonly ShelterService _shelterService;

        public ShelterController(ShelterService shelterService)
        {
            _shelterService = shelterService;
        }

        // GET: ShelterController
        public ActionResult Index()
        {
            var shelters = _shelterService.GetAll() ?? new List<Shelter>();
            return View(shelters);
        }

        // GET: ShelterController/Details/5
        public ActionResult Details(int id)
        {
            var shelter = _shelterService.GetById(id);
            return View(shelter);
        }

        // GET: ShelterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShelterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShelterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShelterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShelterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShelterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
