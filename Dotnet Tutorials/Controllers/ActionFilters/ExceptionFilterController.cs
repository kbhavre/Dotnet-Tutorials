using Dotnet_Tutorials.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.ActionFilters
{
    public class ExceptionFilterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ServiceFilter(typeof(ExceptionFilter))]
        public IActionResult Divide(int x, int y)
        {
            Console.WriteLine("Inside Divide Controller");
            int res = x / y;
            ViewBag.Result = res;

            return View("Result");
        }
    }
}
