using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstN;
            Console.WriteLine("Enter first number:");
            firstN = Console.ReadLine();

            double b = Convert.ToInt32(firstN);

            string secondN;
            Console.WriteLine("Enter second number:");
            secondN = Console.ReadLine();

            double a = Convert.ToInt32(secondN);

            double result = (b + a) / 2;
            Console.WriteLine("Your result: " + result);

        }
    }
}
