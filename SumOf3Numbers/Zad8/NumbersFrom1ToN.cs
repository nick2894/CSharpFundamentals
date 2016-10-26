using System;
namespace Zad8
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            ushort n = ushort.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
   

