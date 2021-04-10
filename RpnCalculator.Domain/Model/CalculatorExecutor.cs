using RpnCalculator.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Domain.Model
{
    public class CalculatorExecutor : ICalculatorExecutor
    {
        public void ApplyOperator(ICalculatorContainer container, string op)
        {
            if (container.Count() < 2)
            {
                throw new InvalidOperationException("The stack must have at least two items to apply an operator");
            }
            var firstItem = container.PopItem();
            var secondItem = container.PopItem();
            double newItem = 0;
            switch (op)
            {
                case "+":
                    newItem = firstItem + secondItem;
                    break;
                case "-":
                    newItem = firstItem - secondItem;
                    break;
                case "*":
                    newItem = firstItem * secondItem;
                    break;
                case "/":
                    newItem = firstItem / secondItem;
                    break;
                default:
                    throw new InvalidOperationException($"The symbol '{op}' is not recognised as a valid operator. Accepted operators are: (+, -, *, /)");

            }
            container.PushItem(newItem);
        }
    }
}
