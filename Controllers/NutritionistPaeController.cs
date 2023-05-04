using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RRS_Controller.Controllers
{
    public class NutritionistPAEController : Controller
    {

        public IActionResult NutritionistPAE()
        {
            return View();
        }

        public IActionResult createMenu()
        {
            return View();
        }

        public IActionResult createFood()
        {
            return View();
        }
        public IActionResult registerMenu()
        {
            return View();
        }

        // GET: NutritionistPAEController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NutritionistPAEController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NutritionistPAEController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NutritionistPAEController/Create
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

        // GET: NutritionistPAEController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NutritionistPAEController/Edit/5
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

        // GET: NutritionistPAEController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NutritionistPAEController/Delete/5
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