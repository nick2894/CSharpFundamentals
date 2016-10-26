using System;

namespace Zad5
{
    class BiggestOf3
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());


            if (a != b && c != b && c != a)

            {
                if (b > a && b > c)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    if (a > b && a > c)
                    {
                        Console.WriteLine(a);
                    }
                    else
                    {
                        Console.WriteLine(c);
                    }
                }
            }
            else
            {
                Console.WriteLine(a);

            }
        }
    }
}
