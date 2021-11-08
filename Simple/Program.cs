using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string data1;
            Console.WriteLine("Enter first number:");
            data1 = Console.ReadLine();

            int b = Convert.ToInt32(data1);

            string data2;
            Console.WriteLine("Enter second number:");
            data2 = Console.ReadLine();

            double a = Convert.ToInt32(data2);

            double result = (b + a) / 2;
            Console.WriteLine("Your result: " + result);

        }
    }
}
