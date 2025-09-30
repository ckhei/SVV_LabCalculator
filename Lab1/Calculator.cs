namespace Lab1;

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            // Return text for an incorrect option entry.
            case "f":
                // require integer input for factorial
                if (num1 % 1 != 0) throw new ArgumentException("Factorial requires an integer first argument.");
                result = Factorial((int)num1);
                break;
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Lab1Divide(double num1, double num2)
    {
        // Lab's tests expect ArgumentException for zero inputs (per step 14b)
        if (num1 == 0 || num2 == 0)
            throw new ArgumentException("Inputs must be non-zero for this lab exercise.");

        return num1 / num2; 
    }
    
    public double Divide(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0) return 1;
        if (num2 == 0) return double.PositiveInfinity;
        return num1 / num2;
    }
    
    public double Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Factorial is undefined for negative numbers.");
        double result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }
    
    // UnknownFunctionA -> permutation nPr = n!/(n-k)!
    public double UnknownFunctionA(int n, int k)
    {
        if (n < 0 || k < 0 || n < k) throw new ArgumentException("Invalid inputs for permutation.");
        return Factorial(n) / Factorial(n - k);
    }
    
    // UnknownFunctionB -> combination nCr
    public double UnknownFunctionB(int n, int k)
    {
        if (n < 0 || k < 0 || n < k) throw new ArgumentException("Invalid inputs for combination.");
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }
    
    public double AreaTriangle(double height, double length)
    {
        return 0.5 * height * length;
    }

    public double AreaCircle(double radius)
    {
        return Math.PI * radius * radius;
    }
    
    // MTBF
    public double MTBF(double totalTime, double failures)
    {
        if (failures == 0) return double.PositiveInfinity;
        return totalTime / failures;
    }

    // Availability
    public double Availability(double mtbf, double mttr)
    {
        return mtbf / (mtbf + mttr);
    }

    // Musa Failure Intensity λ(τ)
    public double MusaFailureIntensity(double lambda0, double v0, double mu)
    {
        return lambda0 * (1 - (mu / v0));
    }

    // Musa Expected Failures μ(τ)
    public double MusaExpectedFailures(double lambda0, double v0, double tau)
    {
        return v0 * (1 - Math.Exp(-(lambda0 / v0) * tau));
    }
    
    public double DefectDensity(double defects, double loc)
    {
        if (loc == 0) return 0; // avoid division by zero
        return defects / loc;
    }
    
    public double UpdatedSSI(double previousSSI, double newSSI)
    {
        return previousSSI + newSSI;
    }
}

// hello