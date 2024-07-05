using Microsoft.AspNetCore.Mvc;
using EmployeeFormApp.Models;
using System;
using System.Collections.Generic; // Include this for List<T>

namespace EmployeeFormApp.Controllers
{
    public class EmployeeController : Controller
    {
        private static List<EmployeeForm> _employees = new List<EmployeeForm>(); // Example in-memory list

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeForm model)
        {
            if (ModelState.IsValid)
            {
                // Example: Save data to a list (in-memory) or database
                _employees.Add(model);

                return RedirectToAction("Success");
            }
            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(_employees);
        }
    }
}
