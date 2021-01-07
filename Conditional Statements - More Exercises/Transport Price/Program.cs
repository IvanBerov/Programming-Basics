using System;
using System.Xml.Schema;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //numberKilometerts
            string dayOrNight = Console.ReadLine();

            double dayTaxiPrice = 0.70 + (0.79 * n);
            double nightTaxiPrice = 0.70 + (0.90 * n);
            double busPrice = 0.09 * n;
            double trainPrice = 0.06 * n;
            double bestPrice = 0;

            if (n < 20)
            {
                if (dayOrNight == "day")
                {
                    bestPrice = dayTaxiPrice;

                }else if (dayOrNight == "night")
                {
                    bestPrice = nightTaxiPrice;
                }
            }

            else if (n >= 20 && n < 100)
            {
                bestPrice = busPrice;
            }

            else if (n >= 100)
            {
                bestPrice = trainPrice;
            }
            Console.WriteLine($"{bestPrice:f2}");

        }
    }
}
