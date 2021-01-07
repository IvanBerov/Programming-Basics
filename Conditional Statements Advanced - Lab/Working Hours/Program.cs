using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            if (weekDay == "Sunday" || (hour < 10 || hour > 18))
            {
                Console.WriteLine("closed");
            }
            else
            {
                Console.WriteLine("open");
            }
        }
    }
}
