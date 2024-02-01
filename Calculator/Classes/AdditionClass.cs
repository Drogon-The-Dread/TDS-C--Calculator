namespace Calculator.Operations
{
    public class Addition : IOperation
    {
        public string OperatorSymbol => "+";

        public double Calculate(double a, double b) => a + b;
    }

}
