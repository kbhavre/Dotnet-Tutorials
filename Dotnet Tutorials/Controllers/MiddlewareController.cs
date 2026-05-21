using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers
{
    public class MiddlewareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AppRun()
        {
            return View();
        }

        public IActionResult AppMap()
        {
            return View();
        }
        public IActionResult ExecutionTimeMiddleware()
        {
            return View();
        }
        public IActionResult IpAddressMiddleware()
        {
            return View();
        }
        public IActionResult RequestLoggingMiddleware()
        {
            return View();
        }
    }
}
