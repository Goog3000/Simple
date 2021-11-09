using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            bool c = false;
            bool d = true;

            if (a == b)
            {
                Console.WriteLine(c);
            }
            else if(a!=b) 
            {
                Console.WriteLine(d);
            }
        }
    }
}
