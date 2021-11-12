using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("You enter number 1");
                    break;
                case 2:
                    Console.WriteLine("You enter number 2");
                    break;
                default:
                    Console.WriteLine("You enter enother number");
                    break;
            }
        }
    }
}
