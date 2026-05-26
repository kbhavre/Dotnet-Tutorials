using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.MpsedcExam
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            model.Total = model.Subject1 + model.Subject2 + model.Subject3;
            model.Percentage = model.Total / 3.0;

            if (model.Percentage >= 90) model.Grade = "A";
            else if (model.Percentage >= 75) model.Grade = "B";
            else if (model.Percentage >= 60) model.Grade = "C";
            else model.Grade = "Fail";
            return View(model);
        }
    }
}
