using System;


namespace Third_digit
{
    class Zad5
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int thirdDigit = (num / 100) % 10;

            if (thirdDigit ==7)
            {
                Console.WriteLine("true") ;

            }
            else
            {
                Console.WriteLine("false " + thirdDigit);
            }
        }
    }
}
