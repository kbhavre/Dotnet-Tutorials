using System.ComponentModel.DataAnnotations;

namespace Dotnet_Tutorials.Models
{
    public class ShoppingCartModel
    {
        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 10000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 1000, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        public decimal TotalBill { get; set; }
    }
}
