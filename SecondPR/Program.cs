using System;

namespace SecondPR
{
    class Program
    {
        static void Main(string[] args)
        {
            double UAHinPLZ = 6.58;
            double PLZ;
            Console.WriteLine("Enter how mach: ");

            PLZ = double.Parse(Console.ReadLine());

            Console.WriteLine(PLZ + " PLZ in UAH = " + UAHinPLZ*PLZ);
        }
    }
}
