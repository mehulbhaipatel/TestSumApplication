using System.ComponentModel.DataAnnotations;

namespace TestSumApplication.Models
{
    public class AddViewModel
    {
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "First number must be an valid number")]
        public double firstNumber { get; set; }
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Second number must be an valid number")]
        public double secondNumber { get; set; }
    }
}
