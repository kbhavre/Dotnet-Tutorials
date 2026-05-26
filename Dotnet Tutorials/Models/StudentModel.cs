using System.ComponentModel.DataAnnotations;

namespace Dotnet_Tutorials.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Student Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject 1 marks are required")]
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public int Subject1 { get; set; }

        [Required(ErrorMessage = "Subject 2 marks are required")]
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public int Subject2 { get; set; }

        [Required(ErrorMessage = "Subject 3 marks are required")]
        [Range(0, 100, ErrorMessage = "Marks must be between 0 and 100")]
        public int Subject3 { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; } = string.Empty;
    }
}
