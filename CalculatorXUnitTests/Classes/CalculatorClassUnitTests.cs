using Calculator;
using Calculator.Operations;

namespace CalculatorXUnitTests
{
    public class CalculatorClassUnitTests
    {
        [Theory]
        [InlineData("1 + 1", 2)]
        [InlineData("2 + 3", 5)]
        [InlineData("10 + 20", 30)]
        public void Evaluate_Addition_ReturnsCorrectResult(string expression, double expected)
        {
            var operations = new List<IOperation> { new Addition() };
            var calculator = new CalculatorClass(operations);

            double result = calculator.Evaluate(expression);

            Assert.Equal(expected, result);
        }
    }
}
