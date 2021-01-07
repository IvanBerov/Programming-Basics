using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            int person = rows * colums;
            double totalIncome = 0;

            if (projectionType == "Premiere")
            {
                totalIncome = person * 12.00;
            }
            else if (projectionType == "Normal")
            {
                totalIncome = person * 7.50;
            }
            else
            {
                totalIncome = person * 5.00;
            }
            Console.WriteLine($"{totalIncome:f2} leva");
        }
    }
}
