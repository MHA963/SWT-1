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

        public double Add(double a, double b) { return a + b; }
        public double Substract(double a, double b) { return a - b; }

        public double Multiply(double a, double b) { return a * b; }
        public double Power(double a, double b)
        {
           return Math.Pow(a, b);
        }
    }

}