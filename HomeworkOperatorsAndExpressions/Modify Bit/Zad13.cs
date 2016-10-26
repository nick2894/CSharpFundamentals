using System;

namespace Modify_Bit
{
    class Zad13
    {
        static void Main()
        {
            
                //input
                ulong n = ulong.Parse(Console.ReadLine());
                byte p = byte.Parse(Console.ReadLine());
                byte v = byte.Parse(Console.ReadLine());
                ulong mask;
                //logic
                if (v == 0)
                {
                    mask = (ulong)~(1 << p);
                    Console.WriteLine(n & mask);
                }
                else
                {
                    mask = (ulong)1 << p;
                    Console.WriteLine(n | mask);
                }
         }
   }
}

    
