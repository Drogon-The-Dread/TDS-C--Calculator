namespace Calculator
{
    public class CalculatorClass
    {
        private readonly List<IOperation> operations;

        public CalculatorClass(IEnumerable<IOperation> operations)
        {
            this.operations = operations.ToList();
        }

        public double Evaluate(string expression)
        {
            var parts = expression.Split(' ');
            if (parts.Length != 3) throw new ArgumentException("Invalid expression format.");

            var operation = operations.FirstOrDefault(op => op.OperatorSymbol == parts[1]);
            if (operation == null) throw new NotImplementedException($"Operation {parts[1]} is not implemented.");

            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[2]);

            return operation.Calculate(a, b);
        }
    }
}
