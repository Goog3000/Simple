using System;

namespace Simple2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;

            Console.WriteLine("Enter first value: ");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second value: ");
            secondValue = double.Parse(Console.ReadLine());


            double result = (firstValue + secondValue) / 2;
            Console.WriteLine("Arythmetic mean: " + result);
        }
    }
}
