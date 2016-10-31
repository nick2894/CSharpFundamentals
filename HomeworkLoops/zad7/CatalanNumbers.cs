using System;
using System.Numerics;

namespace zad7
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            

            BigInteger factorieln = 1;
            BigInteger factorieln2 = 1;
            BigInteger factorielnextn = 1;

            for (int i = 1; i <= 2*n; i++)
            {
                if (n >= i)
                {
                    factorieln *= i;
                }
                if (2*n>= i)
                {
                    factorieln2 *= i;
                }
                if (n +1 >= i)
                {
                    factorielnextn *= i;
                }
            }
            BigInteger sum = factorieln2 / (factorielnextn * factorieln);

            Console.WriteLine(sum);
        }
    }
}
