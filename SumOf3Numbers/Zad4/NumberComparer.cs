using System;

namespace Zad5
{
    class FormattingNumbers
     {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }

        }
    }
}
