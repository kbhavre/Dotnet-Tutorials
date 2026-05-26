using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.MpsedcExam
{
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ShoppingCartModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.TotalBill = model.Price * model.Quantity;
            return View(model);
        }
    }
}
