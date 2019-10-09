using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorApp.Services
{
    public interface ICalculator
    {
        double Calculate(double x, double y, string operand);
    }
}