using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.MpsedcExam
{
    public class SimpleInterestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SimpleInterestModel model)
        {
            model.Interest = (model.Principal * model.Rate * model.Time) / 100;
            model.Amount = model.Interest + model.Principal;

            return View(model);
        }
    }
}
