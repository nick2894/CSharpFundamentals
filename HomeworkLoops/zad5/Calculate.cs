using System;

namespace zad5
{
    class Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            double factoriel = 1;

            for (int i = 1; i < n; i++)
            {
                factoriel *= i;
                sum += factoriel / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
        }



    }
}

