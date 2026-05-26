using System.ComponentModel.DataAnnotations;

namespace Dotnet_Tutorials.Models
{
    public class AttendanceModel
    {
        [Required(ErrorMessage = "Total classes is required")]
        [Range(1, 1000, ErrorMessage ="Total classes must be greater than 0")]
        public int TotalClasses { get; set; }

        [Required(ErrorMessage = "Attended classes is required")]
        [Range(0, 1000, ErrorMessage = "Attended classes can't be negative ")]
        public int AttendedClasses { get; set; }

        public double AttendedPercentage { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
