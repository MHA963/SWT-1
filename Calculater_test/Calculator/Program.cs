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
            //Console.WriteLine(cal.Add(1,5));
            //Console.WriteLine(cal.Substract(3, 2));
            //Console.WriteLine(cal.Multiply(2, 2));
            //Console.WriteLine(cal.Power(3, 2));
        }
    }
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }
        
        public double Add(double a, double b) 
        { 
            Accumulator = a + b;
            return Accumulator;
        }
        
        public double Substract(double a, double b) { Accumulator =  a - b; return Accumulator; }

<<<<<<< HEAD
        public double Multiply(double a, double b) { return a * b; }
        public double Power(double a, double b)
        {
           return Math.Pow(a, b);
=======
        public double Multiply(double a, double b) { Accumulator = a * b; return Accumulator; }
        
        public double Power(double a, double exp)
        {
            if (exp == 0)
            { Accumulator = 1;
                return Accumulator;
            }
            double result = 1;
            for (int i = 0; i < exp; i++) { result *= a; }
            Accumulator = result;
            return Accumulator;
>>>>>>> 8fb5e839b77df9cf01a6cfd743321d9f62fd3752
        }
        
        public double divide(double divident, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("cant divide by 0");
                return 0;
            }
            else
                return Accumulator = divident / divisor;
                        
        }

        public void Clear()
        {
            Accumulator = 0;
        }




    }

}