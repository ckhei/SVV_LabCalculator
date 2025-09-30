Feature: UsingCalculatorFactorial
In order to calculate factorials
As someone who struggles with math
I want to be able to use my calculator to do this

    @Factorial
    Scenario: Calculating factorial of 5
        Given I have a calculator
        When I have entered 5 into the calculator and press factorial
        Then the result should be 120

    @Factorial
    Scenario: Calculating factorial of 0
        Given I have a calculator
        When I have entered 0 into the calculator and press factorial
        Then the result should be 1