using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CalculatorApp.Models
{
    public class CalculatorViewModel
    {
        public double LeftInput { get; set; }
        public double RightInput { get; set; }
        public string Operand { get; set; }
        public double? Result { get; set; }
    }
}
