using System;
using CalculatorApp.Models;

namespace CalculatorApp.Services
{
    public class CalculatorFacade : ICalculatorFacade
    {
        private readonly ICalculator _calculatorService;

        public CalculatorFacade(ICalculator calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public CalculatorViewModel Calculate(CalculatorViewModel dataModel)
        {
            var newModel = new CalculatorViewModel();

            if (dataModel.Operand != null)
            {
                newModel.Result = _calculatorService.Calculate(
                dataModel.LeftInput,
                dataModel.RightInput,
                dataModel.Operand);

                return newModel;
            }

            return dataModel;
        }
    }
}