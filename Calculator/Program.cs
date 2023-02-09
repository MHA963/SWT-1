// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Add(1,5));
            Console.WriteLine(cal.Substract(3, 2));
            Console.WriteLine(cal.Multiply(2, 2));
            Console.WriteLine(cal.Power(3, 2));
        }
    }
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }
        
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
        
        public double divide(double divident, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("cant divide by 0");
                return 0;
            }
            else
                return divident / divisor;
                        
        }

        




    }

}