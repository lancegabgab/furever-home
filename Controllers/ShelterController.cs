using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace furever_home.Controllers
{
    public class ShelterController : Controller
    {
        // GET: ShelterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ShelterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
