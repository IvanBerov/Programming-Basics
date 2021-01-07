using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int torteCount = int.Parse(Console.ReadLine());
            int waffelsCount = int.Parse(Console.ReadLine());
            int pancakseCount = int.Parse(Console.ReadLine());

            double dayTorteSum = torteCount * 45;
            double dayWaffelsSum = waffelsCount * 5.80;
            double dayPancakesSum = pancakseCount * 3.20;

            double dayTotalProfit = (dayTorteSum + dayWaffelsSum + dayPancakesSum) * bakersCount;
            double wholeCampaignSum = dayTotalProfit * days;
            double amountAfterCosts = wholeCampaignSum - (wholeCampaignSum / 8);

            Console.WriteLine(amountAfterCosts);

        }
    }
}
