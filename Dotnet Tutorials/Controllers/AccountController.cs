using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username)
        {
            HttpContext.Session.SetString(
                "UserName",
                username);

            return RedirectToAction(
                "Dashboard",
                "AuthorizationFilter");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}