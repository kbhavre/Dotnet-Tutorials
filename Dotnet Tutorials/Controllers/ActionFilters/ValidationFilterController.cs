using Dotnet_Tutorials.Filters;
using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.ActionFilters
{
    public class ValidationFilterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ServiceFilter(typeof(CustomValidationFilter))]
        public IActionResult Submit(UserFormModel model)
        {
            Console.WriteLine("Controller Executed");
            return View("Success", model);
        }
    }
}
