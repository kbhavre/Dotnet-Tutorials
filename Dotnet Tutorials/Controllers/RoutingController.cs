using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers
{
    public class RoutingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ConventionalRouting()
        {
            return View();
        }
        public IActionResult AttributeRouting()
        {
            return View();
        }
        public IActionResult RouteParameters()
        {
            return View();
        }
        public IActionResult RouteConstraints()
        {
            return View();
        }
    }
}
