using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Domain.Interface
{
    public interface ICalculatorService
    {
        void Push(double item);
        void Calculate(string op);
        void Clear();

        string GetStack();
    }
}
