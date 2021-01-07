using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if (numberOfPoints <= 100)
            {
                bonus += 5;
            }else if (numberOfPoints > 1000)
            {
                bonus = numberOfPoints * 0.10;
            }
            else
            {
                bonus = numberOfPoints * 0.20;
            }
            if (numberOfPoints % 2 == 0)
            {
                bonus += 1;
            }else if (numberOfPoints % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + numberOfPoints);
        }
    }
}
