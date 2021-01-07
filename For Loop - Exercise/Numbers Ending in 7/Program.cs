using System;

namespace Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 7; number <= 997; number++)
            {
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
