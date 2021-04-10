using NUnit.Framework;
using RpnCalculator.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnCalculator.Domain.Tests
{
    public class CalculatorExecutorTests
    {

        [Test]
        public void ShouldApplyOperatorSuccefully()
        {
            CalculatorContainer container = new CalculatorContainer();
            CalculatorExecutor executor = new CalculatorExecutor();
            container.PushItem(5);
            container.PushItem(7);
            container.PushItem(8);
            executor.ApplyOperator(container, "+");            
            Assert.AreEqual("5;15", container.PrettyDisplay());
            container.PushItem(10);
            executor.ApplyOperator(container, "-");
            Assert.AreEqual("5;-5", container.PrettyDisplay());
            executor.ApplyOperator(container, "*");
            Assert.AreEqual("-25", container.PrettyDisplay());
        }

        [Test]
        public void ShouldApplyOperatorRaiseExceptionWhenStackEmpty()
        {
            CalculatorContainer container = new CalculatorContainer();
            CalculatorExecutor executor = new CalculatorExecutor();
            container.PushItem(5);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => executor.ApplyOperator(container, "+"));
            Assert.That(ex.Message, Is.EqualTo("The stack must have at least two items to apply an operator"));
        }

        [Test]
        public void ShouldApplyOperatorRaiseExceptionWhenOperatorInvalid()
        {
            CalculatorContainer container = new CalculatorContainer();
            CalculatorExecutor executor = new CalculatorExecutor();
            container.PushItem(5);
            container.PushItem(5);
            container.PushItem(5);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => executor.ApplyOperator(container, ":"));
            Assert.That(ex.Message, Is.EqualTo("The symbol ':' is not recognised as a valid operator. Accepted operators are: (+, -, *, /)"));
        }

    }
}
