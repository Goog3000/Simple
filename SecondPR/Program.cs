using System;

namespace SecondPR
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1afsdf";

            int a;
            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
