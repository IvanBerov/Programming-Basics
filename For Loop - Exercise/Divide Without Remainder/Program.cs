using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum % 2 == 0)
                {
                    p1++;
                }
                if (currNum % 3 == 0)
                {
                    p2++;
                }
                if (currNum % 4 == 0)
                {
                    p3++;
                }
            }
            double p1Result = p1 / n * 100;
            double p2Result = p2 / n * 100;
            double p3Result = p3 / n * 100;

            Console.WriteLine($"{p1Result:f2}%");
            Console.WriteLine($"{p2Result:f2}%");
            Console.WriteLine($"{p3Result:f2}%");
            
        }
    }
}
