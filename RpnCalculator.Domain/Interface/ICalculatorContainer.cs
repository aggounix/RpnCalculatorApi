using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Domain.Interface
{
    public interface ICalculatorContainer
    {
        void PushItem(double item);
        double PopItem();
        void Clean();
        int Count();
        string PrettyDisplay();
    }
}
