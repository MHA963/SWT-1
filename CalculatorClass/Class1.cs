namespace CalculatorClass
{
    public class Class1
    {

        public double Add(double a, double b) { return a + b; }
        public double Substract(double a, double b) { return a - b; }

        public double Multiply(double a, double b) { return a * b; }
        public double Power(double a, double exp)
        {
            if (exp == 0) return 1;
            double result = 1;
            for (int i = 0; i < exp; i++) { result *= a; }
            return result;
        }
    }
}