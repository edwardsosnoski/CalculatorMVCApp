using System;
using CalculatorApp.Models;

namespace CalculatorApp.Services
{
    public interface ICalculatorFacade
    {
        CalculatorViewModel Calculate(CalculatorViewModel dataModel);
    }
}