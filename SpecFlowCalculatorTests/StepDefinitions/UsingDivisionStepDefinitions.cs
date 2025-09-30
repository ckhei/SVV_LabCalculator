using NUnit.Framework;
using Reqnroll;
using Lab1;
using System;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingDivisionStepDefinitions
    {
        private readonly CalculatorContext _ctx;

        public UsingDivisionStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When("I have entered {double} and {double} into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double a, double b)
        {
            _ctx.Result = _ctx.Calculator.Divide(a, b);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenDivisionResultShouldBe(string expected)
        {
            double expectedValue = expected switch
            {
                "positive_infinity" => double.PositiveInfinity,
                _ => double.Parse(expected)
            };
            NUnit.Framework.Assert.That(_ctx.Result, Is.EqualTo(expectedValue));
        }
    }
}