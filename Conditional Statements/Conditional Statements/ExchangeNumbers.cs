using System;

namespace Zad1

{
    class ExchangeNumbers
    {
        static void Main()
        {
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.Write("{0} {1} ", b, a);
            }
            else
            {
                Console.Write("{0} {1} ", a, b);
            }
        }
    }
}
