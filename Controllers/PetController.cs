using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FureverHome.Services;

namespace FureverHome.Controllers
{
    public class PetController : Controller
    {
        private readonly PetService _petService;

        public PetController(PetService petService)
        {
            _petService = petService;
        }
        // GET: PetController
        public ActionResult Index()
        {
            var pets = _petService.GetAll();
            return View(pets);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int id)
        {
            var pet = _petService.GetById(id);
            return View(pet);
        }

        // GET: PetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetController/Create
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

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetController/Edit/5
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

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetController/Delete/5
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
