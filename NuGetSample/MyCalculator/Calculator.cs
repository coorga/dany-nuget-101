namespace MyCalculator;

public class Calculator     
{
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a">number 1</param>
    /// <param name="b">number 2</param>
    /// <returns>result of adding number 1 and number 2</returns>
    public double Add(double a, double b)
    {
        //Comment for testing
        return a + b;
    }

    public double Subtract(double a, double b) => a - b;
}