using Calculator;

namespace CalculatorXUnitTests;

public class CalculatorClassTests
{
    [Theory]
    [InlineData("1 + 1", 2)]
    [InlineData("2 + 3", 5)]
    [InlineData("10 + 20", 30)]
    public void Evaluate_Addition_ReturnsCorrectResult(string expression, double expected)
    {
        var calculator = new CalculatorClass();

        double result = calculator.Evaluate(expression);

        Assert.Equal(expected, result);
    }
}