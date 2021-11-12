using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("En even number");
            }
            else
            {
                Console.WriteLine("Not even number");
            }
        }
    }
}
