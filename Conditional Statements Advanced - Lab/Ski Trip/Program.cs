using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string feedback = Console.ReadLine();

            double totalPriceRoom = daysToStay * 18.00;
            double totalPriceApartment = daysToStay * 25.00;
            double totalPricePresident = daysToStay * 35.00;
            double priceWithDiscount = 0;
            double totalPrice = 0;

            if (daysToStay < 10)
            {
                if(typeOfRoom== "room for one person")
                {
                    priceWithDiscount = totalPriceRoom;
                }
                else if (typeOfRoom== "apartment")
                {
                    priceWithDiscount = totalPriceApartment * 0.70;
                }
                else
                {
                    priceWithDiscount = totalPricePresident * 0.90;
                }
            }
            else if (daysToStay >= 10 && daysToStay <= 15)
            {
                if (typeOfRoom == "room for one person")
                {
                    priceWithDiscount = totalPriceRoom;
                }
                else if (typeOfRoom == "apartment")
                {
                    priceWithDiscount = totalPriceApartment * 0.65;
                }
                else
                {
                    priceWithDiscount = totalPricePresident * 0.85;
                }
            }
            else
            {
                if (typeOfRoom == "room for one person")
                {
                    priceWithDiscount = totalPriceRoom;
                }
                else if (typeOfRoom == "apartment")
                {
                    priceWithDiscount = totalPriceApartment * 0.50;
                }
                else
                {
                    priceWithDiscount = totalPricePresident * 0.80;
                }
            }
            if (feedback == "positive")
            {
                totalPrice = priceWithDiscount * 1.25;
            }
            else
            {
                totalPrice = priceWithDiscount * 0.90;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
