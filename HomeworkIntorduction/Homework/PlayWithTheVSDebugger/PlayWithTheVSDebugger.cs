using System;


namespace PlayWithTheVSDebugger
{
    class PlayWithTheVSDebugger
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter number :");
            number = Convert.ToInt32(Console.ReadLine());
            while (number <= 1000)
            {
                Console.WriteLine( "Value of the number :   " + number);
                number++;
            } 
            Console.ReadLine();
        }
    }
}
