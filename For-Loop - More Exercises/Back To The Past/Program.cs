using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int yearsOld = 18;
            int diff = yearToLive - 1800;


            for (int i = 0; i <= diff; i++)
            {
                if (i % 2 == 0)
                {
                    heritageMoney -= 12000;
                }
                else
                {
                     heritageMoney -= 12000 + (50 * yearsOld);
                }
                yearsOld++;
            }

            if (heritageMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritageMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(heritageMoney):f2} dollars to survive.");
            }
        }


    }
}
