using NUnit.Framework;
using Reqnroll;
using Lab1;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingFactorialStepDefinitions
    {
        private readonly CalculatorContext _ctx;

        public UsingFactorialStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When("I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredNumberAndPressFactorial(int n)
        {
            _ctx.Result = _ctx.Calculator.Factorial(n);
        }

        [Then("the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double expected)
        {
            NUnit.Framework.Assert.That(_ctx.Result, Is.EqualTo(expected));
        }
    }
}