using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class LcController1 : Controller
    {
        // GET: LcController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: LcController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LcController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LcController1/Create
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

        // GET: LcController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LcController1/Edit/5
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

        // GET: LcController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LcController1/Delete/5
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
