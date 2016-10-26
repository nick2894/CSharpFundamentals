using System;


namespace PointCircleRectangle
{
    class Zad10
    {
        static void Main()
        {

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5d;
            double sum = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2));

            if (sum <= r)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if ((x <= 5) && (x >= -1))
            {
                if ((y <= 1) && (y >= -1))
                {
                    Console.Write("inside rectangle ");
                }
                else
                {
                    Console.Write("outside rectangle ");
                }
            }
            else
            {
                Console.Write("outside rectangle ");
            }
        }

    }
}