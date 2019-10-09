using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorApp.Services
{
    public class CalculatorService : ICalculator
    {
        public double Calculate(double x, double y, string operand)
        {
            switch (operand)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                case "/":
                    return x / y;
                default:
                    throw new ArgumentException($"Error: That is not a valid operator.", operand);
            }
        }
    }
}