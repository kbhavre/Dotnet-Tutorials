using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.MpsedcExam
{
    public class EmployeeController : Controller
    {
        static List<EmployeeModel> employees =
            new List<EmployeeModel>();

        // SHOW ALL EMPLOYEES

        [HttpGet]
        public IActionResult Index(string searchText)
        {
            var filteredEmployees = employees;

            if (!string.IsNullOrEmpty(searchText))
            {
                filteredEmployees = employees
                    .Where(x =>
                        x.Name.Contains(searchText,
                        StringComparison.OrdinalIgnoreCase)
                        ||
                        x.Department.Contains(searchText,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            ViewBag.SearchText = searchText;

            return View(filteredEmployees);
        }

        // CREATE EMPLOYEE PAGE

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // ADD EMPLOYEE

        [HttpPost]
        public IActionResult Create(EmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Id =
                employees.Count > 0
                ? employees.Max(x => x.Id) + 1
                : 1;

            employees.Add(model);

            return RedirectToAction("Index");
        }

        // EDIT PAGE

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee =
                employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // UPDATE EMPLOYEE

        [HttpPost]
        public IActionResult Edit(EmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var employee =
                employees.FirstOrDefault(x => x.Id == model.Id);

            if (employee == null)
            {
                return NotFound();
            }

            employee.Name = model.Name;
            employee.Department = model.Department;
            employee.Salary = model.Salary;

            return RedirectToAction("Index");
        }

        // DELETE EMPLOYEE

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee =
                employees.FirstOrDefault(x => x.Id == id);

            if (employee != null)
            {
                employees.Remove(employee);
            }

            return RedirectToAction("Index");
        }
    }
}