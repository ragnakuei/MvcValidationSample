using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcValidationSample.Models;

namespace MvcValidationSample.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonViewModel personViewModel)
        {
            if (ModelState.IsValid)
            {
                TempData["Result"] = "新增完畢";
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}
