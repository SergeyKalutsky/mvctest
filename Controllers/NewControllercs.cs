using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mvctest.Controllers
{
    public class NewControllercs : Controller
    {
        // GET: NewControllercs
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewControllercs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewControllercs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewControllercs/Create
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

        // GET: NewControllercs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewControllercs/Edit/5
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

        // GET: NewControllercs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewControllercs/Delete/5
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
