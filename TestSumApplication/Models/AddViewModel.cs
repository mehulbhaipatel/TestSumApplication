using System.ComponentModel.DataAnnotations;

namespace TestSumApplication.Models
{
    public class AddViewModel
    {
        [Range(long.MinValue, long.MaxValue, ErrorMessage = "First number must be an valid number")]
        public long firstNumber { get; set; }
        [Range(long.MinValue, long.MaxValue, ErrorMessage = "Second number must be an valid number")]
        public long secondNumber { get; set; }
    }
}
