using NUnit.Framework;
using Reqnroll;
using Lab1;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private readonly CalculatorContext _ctx;

        public UsingCalculatorStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [Given("I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _ctx.Calculator = new Calculator();
        }

        [When("I have entered {double} and {double} into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double a, double b)
        {
            _ctx.Result = _ctx.Calculator.Add(a, b);
        }

        [Then("the result should be {double}")]
        public void ThenTheResultShouldBeOnTheScreen(double expected)
        {
            NUnit.Framework.Assert.That(_ctx.Result, Is.EqualTo(expected));
        }
    }
}