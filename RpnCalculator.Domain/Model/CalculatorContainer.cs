using RpnCalculator.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Domain.Model
{
    public class CalculatorContainer : ICalculatorContainer
    {
        private Stack<double> Stack;

        public CalculatorContainer()
        {
            Stack = new Stack<double>();
        }


        public void PushItem(double item)
        {
            Stack.Push(item);
        }

        public double PopItem()
        {
            return Stack.Pop();
        }

        public int Count()
        {
            return Stack.Count;
        }

        public string PrettyDisplay()
        {
            return string.Join(";", Stack.Reverse());
        }

        public void Clean()
        {
            Stack.Clear();
        }
    }
}
