using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.MVC
{
    public class MVCBasicsController : Controller
    {

        public IActionResult ImpQuestions()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControllersAndActions()
        {
            return View();
        }

        public IActionResult DependencyInjection()
        {
            return View();
        }


    }
}
