using System.ComponentModel.DataAnnotations;

namespace Dotnet_Tutorials.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, 1000000, ErrorMessage = "Salary must be greater than  0")]
        public decimal Salary { get; set; } 
    }
}
