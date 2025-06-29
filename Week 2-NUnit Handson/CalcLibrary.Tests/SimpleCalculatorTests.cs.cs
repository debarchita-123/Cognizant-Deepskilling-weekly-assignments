using NUnit.Framework;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            _calculator.AllClear();
        }

        [Test]
        [TestCase(5, 3, 8)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 0, 0)]
        public void Addition_ShouldReturnCorrectSum(double a, double b, double expected)
        {
            var result = _calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        // Add other test methods as in your original code...
    }
}
