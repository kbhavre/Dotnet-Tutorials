using Dotnet_Tutorials.Filters;
using Dotnet_Tutorials.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Tutorials.Controllers.ActionFilters
{
    public class LoggerFilterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ServiceFilter(typeof(RequestLoggingFilter))]
        public IActionResult GetProduct(int productId)
        {
            Console.WriteLine("Inside Controller Action");

            var product = new ProductModel
            {
                ProductId = productId,
                ProductName = "Laptop",
                Price = 55000
            };
            return View("Result", product);
        }
    }
}
