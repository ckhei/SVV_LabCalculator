Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

    @Musa
    Scenario: Calculating current failure intensity
        Given I have a calculator
        When I have entered 0.05, 20, 0 into the calculator and press MusaFailureIntensity
        Then the musa result should be "0.04"

    @Musa
    Scenario: Calculating average expected failures
        Given I have a calculator
        When I have entered 0.05, 20, 20 into the calculator and press MusaExpectedFailures
        Then the musa result should be "15"