using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers
{
    public class CSharpBasicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GotoStatement()
        {
            return View();
        }
    }
}
