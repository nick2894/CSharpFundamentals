﻿using System;


namespace Print_Long_Sequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
                
            }
        }
    }
}