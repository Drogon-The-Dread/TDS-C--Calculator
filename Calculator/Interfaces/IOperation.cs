namespace Calculator
{
    public interface IOperation
    {
        double Calculate(double a, double b);
        string OperatorSymbol { get; }
    }
}
