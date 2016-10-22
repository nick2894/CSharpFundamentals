using System;


namespace MyFirstVariable
{
    class Startup
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            int max = int.MaxValue;
            int age = 500;
            byte byteAge = (byte)age;
            Console.WriteLine(byteAge); 
            /*Console.WriteLine(maxByte + "," );
            Console.WriteLine(max + "," );    
            //Console.WriteLine(min + "," );  */ 
        }
    }
}
