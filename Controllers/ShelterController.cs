using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FureverHome.Services;
using FureverHome.Models;

namespace FureverHome.Controllers
{
    [Authorize]
    public class ShelterController : Controller
    {
        private readonly ShelterService _shelterService;

        public ShelterController(ShelterService shelterService)
        {
            _shelterService = shelterService;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var shelters = _shelterService.GetAll() ?? new List<Shelter>();
            return View(shelters);
        }

        [AllowAnonymous]
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

        public IActionResult Join()
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
            
        [HttpPost]
        public IActionResult Join()
        {
            return RedirectToAction("Index", "Shelter");
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
