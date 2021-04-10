using NUnit.Framework;
using RpnCalculator.Domain.Model;

namespace RpnCalculator.Domain.Tests
{
    public class CalculatorContainerTests
    {
        [Test]
        public void ShouldPushItemToStack()
        {
            CalculatorContainer container = new CalculatorContainer();
            container.PushItem(5);
            Assert.That(container.Count() == 1);
            var lastItem = container.PopItem();
            Assert.AreEqual(5, lastItem);
        }



        [Test]
        public void ShouldDisplayStack()
        {
            CalculatorContainer container = new CalculatorContainer();
            container.PushItem(5);
            container.PushItem(7);

            Assert.AreEqual("5;7", container.PrettyDisplay());
        }


        [Test]
        public void ShouldCoutStack()
        {
            CalculatorContainer container = new CalculatorContainer();
            Assert.AreEqual(0, container.Count());
            container.PushItem(5);
            container.PushItem(7);
            Assert.AreEqual(2, container.Count());
            container.PushItem(19);
            Assert.AreEqual(3, container.Count());
        }

        [Test]
        public void ShouldCleanEmptyStack()
        {
            CalculatorContainer container = new CalculatorContainer();
            container.PushItem(5);
            container.PushItem(5);
            Assert.That(container.Count() > 0);
            container.Clean();
            Assert.That(container.Count() == 0);
        }
    }
}