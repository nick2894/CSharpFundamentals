using System;
using System.Numerics;

namespace zad6
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger factorieln = 1;
            BigInteger factorielk = 1;
            BigInteger factorielnk = 1;

            for (int i = 1; i <= Math.Max(n, k); i++)
            {
                if (n >= i)
                {
                    factorieln *= i;
                }
                if (k >= i)
                {
                    factorielk *= i;
                }
                if (n-k >=i)
                {
                    factorielnk *= i;
                }
            }
            BigInteger sum = factorieln / (factorielk * factorielnk);

            Console.WriteLine(sum);
        }
    }
}
