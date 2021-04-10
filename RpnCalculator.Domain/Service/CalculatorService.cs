using RpnCalculator.Domain.Interface;
using System;


namespace RpnCalculator.Domain.Service
{
    public class CalculatorService : ICalculatorService
    {
        public ICalculatorContainer CalculatorContainer { get; set; }
        public ICalculatorExecutor CalculatorExecutor { get; set; }

        public CalculatorService(ICalculatorContainer calculatorContainer, ICalculatorExecutor calculatorExecutor)
        {
            CalculatorExecutor = calculatorExecutor;
            CalculatorContainer = calculatorContainer;
        }


        public void Calculate(string op)
        {
            CalculatorExecutor.ApplyOperator(CalculatorContainer, op);
        }

        public void Push(double item)
        {
            CalculatorContainer.PushItem(item);
        }

        public void Clear()
        {
            CalculatorContainer.Clean();
        }

        public string GetStack()
        {
            return CalculatorContainer.PrettyDisplay();
        }
    }
}
