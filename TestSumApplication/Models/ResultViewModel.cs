using System.Collections.Generic;

namespace TestSumApplication.Models
{
    public class ResultViewModel
    {
        public bool IsSuccess { get; set; }

        public List<string> ErrorMsgs { get; set; }
    }
}
