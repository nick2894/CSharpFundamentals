using System;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
           short a = short.Parse(Console.ReadLine());
           short b = short.Parse(Console.ReadLine());
           short c = short.Parse(Console.ReadLine());
            int sum = (a + b + c);

            Console.WriteLine(sum);
        }
    }
}
