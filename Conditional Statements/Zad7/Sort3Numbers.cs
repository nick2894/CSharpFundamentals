﻿using System;

namespace Zad7
{
    class Sort3Numbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());



            if (a > b && a > c)

            {
                Console.WriteLine("{0} {1} {2} ", a, b, c);
            }
            else
            {
                if (c > b && c > a)
                {
                    Console.WriteLine("{0} {1} {2} ", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} ", b, c, a);
                }

            }
        }
    }
}
