using NUnit.Framework;
using Reqnroll;
using Lab1;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingMusaStepDefinitions
    {
        private readonly CalculatorContext _ctx;

        public UsingMusaStepDefinitions(CalculatorContext ctx) => _ctx = ctx;

        [When("I have entered (.*) and (.*) into the calculator and press MusaFailureIntensity")]
        
        [When("I have entered (.*), (.*), and (.*) into the calculator and press MusaFailureIntensity")]
        public void WhenICalculateMusaFailureIntensity(double lambda0, double v0, double mu)
        {
            _ctx.Result = _ctx.Calculator.MusaFailureIntensity(lambda0, v0, mu);
        }

        [When("I have entered (.*), (.*), and (.*) into the calculator and press MusaExpectedFailures")]
        public void WhenICalculateMusaExpectedFailures(double lambda0, double v0, double tau)
        {
            _ctx.Result = _ctx.Calculator.MusaExpectedFailures(lambda0, v0, tau);
        }


        [Then("the musa result should be \"(.*)\"")]
        public void ThenTheMusaResultShouldBe(string expected)
        {
            double expectedValue = double.Parse(expected);
            NUnit.Framework.Assert.That(_ctx.Result, Is.EqualTo(expectedValue).Within(0.0001));
        }
    }
}