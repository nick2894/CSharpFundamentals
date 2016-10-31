using System;

namespace HomeworkLoops
{
    class NumbersFrom1ToN
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i <= number - 1; i++)
            {
                int number2 = i + 1;

                if (i <= number)
                {
                    Console.Write("{0} ", number2);

                }



            }
        }
    }
}
