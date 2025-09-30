using NUnit.Framework;
using Reqnroll;
using Lab1;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingQualityMetricsStepDefinitions
    {
        private readonly CalculatorContext _ctx;

        public UsingQualityMetricsStepDefinitions(CalculatorContext ctx)
        {
            _ctx = ctx;
        }

        // -----------------------
        // Defect Density
        // -----------------------
        [When("I have entered (.*) defects and (.*) lines of code into the calculator and press DefectDensity")]
        public void WhenICalculateDefectDensity(double defects, double loc)
        {
            _ctx.Result = _ctx.Calculator.DefectDensity(defects, loc);
        }

        [Then("the defect density result should be \"(.*)\"")]
        public void ThenTheDefectDensityResultShouldBe(string expected)
        {
            double expectedValue = double.Parse(expected);
            NUnit.Framework.Assert.That(_ctx.Result, Is.EqualTo(expectedValue).Within(0.0001));
        }

        // -----------------------
        // Shipped Source Instructions (SSI)
        // -----------------------
        [When("I have entered (.*) previous SSI and (.*) new SSI into the calculator and press UpdatedSSI")]
        public void WhenICalculateUpdatedSSI(double previousSSI, double newSSI)
        {
            _ctx.Result = _ctx.Calculator.UpdatedSSI(previousSSI, newSSI);
        }

        [Then("the updated SSI result should be \"(.*)\"")]
        public void ThenTheUpdatedSSIResultShouldBe(string expected)
        {
            double expectedValue = double.Parse(expected);
            NUnit.Framework.Assert.That(_ctx.Result, Is.EqualTo(expectedValue).Within(0.0001));
        }
    }
}