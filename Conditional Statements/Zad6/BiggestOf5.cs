using System;

namespace Zad6
{
    class BiggestOf5
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

           double biggestOfThree = Math.Max(Math.Max(a, b), c);
           double biggestOfTwo = Math.Max(Math.Max(d, e), biggestOfThree);
            Console.WriteLine(biggestOfTwo);

        }
    }
}
