using System;


namespace PrimeCheck
{
    class Zad8
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int rem = 0;
            string isPrime = "true";
            if (num > 1)
            {
                for (int i = 2; i < num; i++)

                {
                    rem = num % i;
                    if (rem == 0)
                    {
                        isPrime = "false";
                        break;
                    }
                }

            }
            else
            {
                isPrime = "false";
            }
            Console.WriteLine(isPrime);
        }


    }
}
