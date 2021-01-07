using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double appPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = numberOfNights * 50.00;
                appPrice = numberOfNights * 65.00;

                if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    studioPrice *= 0.95;
                }
                else if (numberOfNights > 14)
                {
                    studioPrice *= 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = numberOfNights * 75.20;
                appPrice = numberOfNights * 68.70;

                if (numberOfNights > 14)
                {
                    studioPrice *= 0.8;
                }
            }
            else if (month == "Juli" || month == "August")
            {
                studioPrice = numberOfNights * 76.00;
                appPrice = numberOfNights * 77.00;

            }
            if (numberOfNights > 14)
            {
                appPrice *= 0.90;
            }
            Console.WriteLine($"Apartment: {appPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
