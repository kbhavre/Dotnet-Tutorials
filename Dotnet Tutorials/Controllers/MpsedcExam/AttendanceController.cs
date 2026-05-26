using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.MpsedcExam
{
    public class AttendanceController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AttendanceModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if(model.AttendedClasses > model.TotalClasses)
            {
                ModelState.AddModelError("AttendedClasses", "Attended classes cannot be greater than Total classes");
                return View(model);
            }

            model.AttendedPercentage = (double)model.AttendedClasses / model.TotalClasses * 100;

            if(model.AttendedPercentage >= 75)
            {
                model.Status = "Eligible";
            }
            else
            {
                model.Status = "Not Eligible";
            }

            return View(model);
        }
    }
}
