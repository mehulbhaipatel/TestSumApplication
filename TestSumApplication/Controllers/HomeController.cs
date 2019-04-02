using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestSumApplication.Models;

namespace TestSumApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(AddViewModel addVm)
        {
            if (ModelState.IsValid)
            {
                double result = addVm.firstNumber + addVm.secondNumber;
                return View("Index", new SumResultViewModel { IsSuccess = true, Sum = result });
            }

            // getting list of error messages from ModelState
            var errors = ModelState.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage).ToList();

            return View("Index", new SumResultViewModel { IsSuccess = false, ErrorMsgs = errors });
        }

    }
}
