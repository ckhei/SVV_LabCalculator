Feature: UsingCalculatorQualityMetrics
In order to measure software quality and track software releases
As a quality engineer
I want to calculate defect density and updated Shipped Source Instructions (SSI)

    @DefectDensity
    Scenario: Calculating Defect Density
        Given I have a calculator
        When I have entered 50 defects and 1000 lines of code into the calculator and press DefectDensity
        Then the defect density result should be "0.05"

    @SSI
    Scenario: Calculating Updated SSI
        Given I have a calculator
        When I have entered 2000 previous SSI and 500 new SSI into the calculator and press UpdateSSI
        Then the SSI result should be "2500"