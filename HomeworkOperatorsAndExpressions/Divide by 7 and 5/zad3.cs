using System;

namespace Divide_by_7_and_5
{
    class zad3
    {
        static void Main()

        {
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("true " + number);
            }
            else
            {

                Console.WriteLine("false " + number);
            }
            

        }
    }
}
