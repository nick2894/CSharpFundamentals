using System;

class PointInACircle
{
    static void Main()
    {
        //double x = double.Parse(Console.ReadLine());
        //double y = double.Parse(Console.ReadLine());
        //double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        //if (distance <= 2)
        //{
        //    Console.WriteLine("yes {0:0.00}", distance);
        //}
        //else
        //{
        //    Console.WriteLine("no {0:0.00}", distance);
        //}
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 2.0d;
        double sum = Math.Sqrt((x * x) + (y * y));
        if (sum < r)
        {
            Console.WriteLine("yes {0:0.00}", sum);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", sum);
        }

    }
}