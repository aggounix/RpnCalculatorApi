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
        private readonly Dictionary<string, Func<double, double, double>> Operations = new()
        {
            {"+", (x, y) => { return x + y; } },
            {"-", (x, y) => { return x - y; } },
            {"*", (x, y) => { return x * y; } },
            {"/", (x, y) => { return x / y; } }
        };
        public void ApplyOperator(ICalculatorContainer container, string op)
        {
            if (container.Count() < 2)
            {
                throw new InvalidOperationException("The stack must have at least two items to apply an operator");
            }
            if (!Operations.ContainsKey(op))
            {
                throw new InvalidOperationException($"The symbol '{op}' is not recognised as a valid operator. Accepted operators are: (+, -, *, /)");
            }
            var firstItem = container.PopItem();
            var secondItem = container.PopItem();
            double newItem = Operations[op](secondItem, firstItem);            
            container.PushItem(newItem);
        }
    }
}
