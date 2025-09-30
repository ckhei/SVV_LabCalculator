using NUnit.Framework;
using Reqnroll;
using Lab1;
using System;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingAvailabilityStepDefinitions
    {
        private readonly CalculatorContext _ctx;

        public UsingAvailabilityStepDefinitions(CalculatorContext ctx)
        {
            _ctx = ctx;
        }

        [When("I have entered {double} and {double} into the calculator and press MTBF")]
        public void WhenICalculateMTBF(double mtbf, double mttr)
        {
            _ctx.Result = _ctx.Calculator.MTBF(mtbf, mttr);
        }

        [When("I have entered {double} and {double} into the calculator and press Availability")]
        public void WhenICalculateAvailability(double mtbf, double mttr)
        {
            _ctx.Result = _ctx.Calculator.Availability(mtbf, mttr);
        }

        [Then("the MTBF result should be {string}")]
        public void ThenTheMTBFResultShouldBe(string expected)
        {
            double expectedValue = double.Parse(expected);
            double actualRounded = Math.Round(_ctx.Result, 3);
            double expectedRounded = Math.Round(expectedValue, 3);
            NUnit.Framework.Assert.That(actualRounded, Is.EqualTo(expectedRounded));
        }

        [Then("the availability result should be {string}")]
        public void ThenTheAvailabilityResultShouldBe(string expected)
        {
            double expectedValue = double.Parse(expected);
            double actualRounded = Math.Round(_ctx.Result, 3);
            double expectedRounded = Math.Round(expectedValue, 3);
            NUnit.Framework.Assert.That(actualRounded, Is.EqualTo(expectedRounded));
        }
    }
}