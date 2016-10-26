using System;

namespace Trapezoids
{
    class Zad9
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double st = h * ((a + b) / 2);
            Console.WriteLine( "{0:F7}", st);
            


        }
    }
}
