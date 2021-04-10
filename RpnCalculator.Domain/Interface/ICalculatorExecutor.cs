using RpnCalculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Domain.Interface
{
    public interface  ICalculatorExecutor
    {
        void ApplyOperator(ICalculatorContainer container, string op);
    }
}
