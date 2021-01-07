using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricity = 0;
            double water = 0;
            double internet = 0;
            double others = 0;


            for (int i = 0; i < months; i++)
            {
                double electro = double.Parse(Console.ReadLine());

                electricity += electro;
                water += 20;
                internet += 15;
                others = (water + internet + electricity) * 1.20;
            }

            
            double averageExpensesMonth = (electricity + water + internet + others) / months;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {averageExpensesMonth:f2} lv");
        }
    }
}
