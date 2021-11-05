using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            data = Console.ReadLine();
            
            int b = Convert.ToInt32(data);
            int a = 5;
            Console.WriteLine(b + a);
        }
    }
}
