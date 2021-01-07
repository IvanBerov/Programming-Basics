using System;

namespace Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
