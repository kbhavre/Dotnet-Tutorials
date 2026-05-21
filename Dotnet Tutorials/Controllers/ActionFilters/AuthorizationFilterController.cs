using Microsoft.AspNetCore.Mvc;
using Dotnet_Tutorials.Filters;

namespace Dotnet_Tutorials.Controllers.ActionFilters
{
    public class AuthorizationFilterController : Controller 
    {
        [AuthorizationFilter]
        public IActionResult Dashboard()
        {
            Console.WriteLine("Authorized User Accessed Dashboard");
            return View();
        }
    }
}
