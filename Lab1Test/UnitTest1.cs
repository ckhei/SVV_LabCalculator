using NUnit.Framework;

namespace Lab1.UnitTests;

public class Tests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }
    
    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }
    
    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
    {
        double result = _calculator.Subtract(20, 7);
        Assert.That(result, Is.EqualTo(13));
    }

    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
    {
        double result = _calculator.Multiply(6, 7);
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
    {
        double result = _calculator.Divide(10, 2);
        Assert.That(result, Is.EqualTo(5));
    }

    // Parameterized test: lab wants ArgumentException for the cases below
    [Test]
    [TestCase(0, 0)]
    [TestCase(0, 10)]
    [TestCase(10, 0)]
    public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
    {
        Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    }
    
    [Test]
    public void Factorial_WhenInputIs5_Returns120()
    {
        double result = _calculator.Factorial(5);
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void Factorial_WithZero_ReturnsOne()
    {
        double result = _calculator.Factorial(0);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Factorial_NegativeInput_ThrowsArgumentException()
    {
        Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
    }
    
    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        double result = _calculator.UnknownFunctionA(5,5);
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        double result = _calculator.UnknownFunctionA(5,4);
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        double result = _calculator.UnknownFunctionA(5,3);
        Assert.That(result, Is.EqualTo(60));
    }
    [Test]
    public void UnknownFunctionA_WhenInvalidInputs_Throws()
    {
        Assert.That(() => _calculator.UnknownFunctionA(-4,5), Throws.ArgumentException);
        Assert.That(() => _calculator.UnknownFunctionA(4,5), Throws.ArgumentException); // n < k
    }
    
    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        double result = _calculator.UnknownFunctionB(5,5);
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        double result = _calculator.UnknownFunctionB(5,4);
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        double result = _calculator.UnknownFunctionB(5,3);
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void UnknownFunctionB_WhenInvalidInputs_Throws()
    {
        Assert.That(() => _calculator.UnknownFunctionB(-4,5), Throws.ArgumentException);
        Assert.That(() => _calculator.UnknownFunctionB(4,5), Throws.ArgumentException);
    }
    
    [Test]
    public void AreaTriangle_WhenHeightAndBaseProvided_ReturnsArea()
    {
        double area = _calculator.AreaTriangle(4, 5); // height, length/base
        Assert.That(area, Is.EqualTo(0.5 * 4 * 5));
    }

    [Test]
    public void AreaCircle_WhenRadiusProvided_ReturnsArea()
    {
        double area = _calculator.AreaCircle(2);
        Assert.That(area, Is.EqualTo(Math.PI * 2 * 2).Within(1e-9));
    }

}