using System;

namespace nBit
{
    class Zad12
    {
        static void Main()
        {
            
            
            ulong p = ulong.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine((p >> n) & 1);
          
        }
    }

}
    
