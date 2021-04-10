using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RpnCalculator.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpnCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpnController : ControllerBase
    {
        private static ICalculatorService CalculatorService;

        private readonly ILogger<RpnController> _logger;

        public RpnController(ILogger<RpnController> logger, ICalculatorService calculatorService)
        {
            _logger = logger;
            CalculatorService = calculatorService;
        }

        [Route("PushItem")]
        [HttpPost]
        public void Push(string operand)
        {
            double x;
            if (!Double.TryParse(operand, out x))
            {
               throw new ArgumentException("Operand should be a double");
            }
            CalculatorService.Push(x);
        }

        [Route("PushOperator")]
        [HttpPost]
        public void PushOperator(string op)
        {
            CalculatorService.Calculate(op);
        }

        [Route("GetStack")]
        [HttpGet]
        public string GetStack()
        {
            return CalculatorService.GetStack();
        }

        [Route("CleanStack")]
        [HttpGet]
        public void CleanStack()
        {
            CalculatorService.Clear();
        }
    }
}
