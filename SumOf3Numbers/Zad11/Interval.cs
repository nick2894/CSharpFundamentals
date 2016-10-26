using System;
namespace Zad11
{
    class Interval
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumOfDivision = 0;


            for(int i = n + 1; i < m; i++)

           {
                int devide = i % 5;
                if (devide == 0)
                {
                    sumOfDivision += 1;
                }
            }
            Console.WriteLine(sumOfDivision);
        }
    }
}


