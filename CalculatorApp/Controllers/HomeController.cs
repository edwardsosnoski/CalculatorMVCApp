using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Models;
using CalculatorApp.Services;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculatorFacade _calculatorFacade;

        public HomeController(ICalculatorFacade calculatorFacade)
        {
            _calculatorFacade = calculatorFacade;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator(CalculatorViewModel model)
        {
            var modelWithData = _calculatorFacade.Calculate(model);
            return View(modelWithData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}