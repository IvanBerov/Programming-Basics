using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double userSpeed = double.Parse(Console.ReadLine());

            if (userSpeed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (userSpeed > 10 && userSpeed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (userSpeed > 50 && userSpeed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (userSpeed > 150 && userSpeed <= 1000)
            {
                Console.WriteLine("ultra fast");

            }
            else
                Console.WriteLine("extremely fast");
        }
    }
}
