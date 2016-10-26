using System;

namespace Moon_Gravity
{
    class Program
    {
        static void Main()
        {
            float weight = float.Parse(Console.ReadLine());

     

            float moonGravity = 0.17f;
            float weightOnMoon = weight * moonGravity;
            Console.WriteLine("{0:F3}", weightOnMoon);
        }
    }
}
