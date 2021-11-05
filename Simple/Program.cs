using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            Console.WriteLine("Enter number:");
            data = Console.ReadLine();

            int b = Convert.ToInt32(data);
            int a = 5;

            int result = b + a;
            Console.WriteLine("Your result: " + result);
        }
    }
}
