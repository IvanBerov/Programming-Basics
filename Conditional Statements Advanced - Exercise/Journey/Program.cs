using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //izhod
            string destination = "";
            string typeOfVacation = "";
            double spendedMoney = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    typeOfVacation = "Camp";
                    spendedMoney = budget * 0.30;
                }
                else if (season == "winter")
                {
                    typeOfVacation = "Hotel";
                    spendedMoney = budget * 0.70;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    typeOfVacation = "Camp";
                    spendedMoney = budget * 0.40;
                }
                else if (season == "winter")
                {
                    typeOfVacation = "Hotel";
                    spendedMoney = budget * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                typeOfVacation = "Hotel";
                spendedMoney = budget * 0.90;
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {spendedMoney:f2}");



        }
    }
}
