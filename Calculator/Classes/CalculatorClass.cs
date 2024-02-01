namespace Calculator
{
    public class CalculatorClass
    {
        public double Evaluate(string expression)
        {
            var parts = expression.Split(' ');
            if (parts.Length == 3 && parts[1] == "+")
            {
                return double.Parse(parts[0]) + double.Parse(parts[2]);
            }
            throw new NotImplementedException("Only addition is implemented.");
        }
    }
}
