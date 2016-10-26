
using System;

namespace ConsoleApplication1
{
    class zad1
    {
        static void Main()
        {
            
            sbyte num = sbyte.Parse(Console.ReadLine());

           
            if (num % 2 == 0)
            {
                Console.WriteLine("even" + " " + num);
            }
            else
            {
                Console.WriteLine("odd" + " " + num);
            }

        }
    }
}
