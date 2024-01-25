using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Views.Departments
{
    public class list : Controller
    {
        // GET: list
        public ActionResult Index()
        {
            return View();
        }

        // GET: list/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: list/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: list/Create
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

        // GET: list/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: list/Edit/5
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

        // GET: list/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: list/Delete/5
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
