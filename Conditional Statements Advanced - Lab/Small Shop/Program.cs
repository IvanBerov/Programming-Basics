﻿using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalPrice = quantity * 0.50;
                }
                else if (product == "water")
                {
                    totalPrice = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    totalPrice = quantity * 1.2;
                }
                else if (product == "sweets")
                {
                    totalPrice = quantity * 1.45;
                }
                else
                {
                    totalPrice = quantity * 1.60;
                }
            }
            if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalPrice = quantity * 0.40;
                }
                else if (product == "water")
                {
                    totalPrice = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    totalPrice = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    totalPrice = quantity * 1.30;
                }
                else
                {
                    totalPrice = quantity * 1.50;
                }
            }
            if (town == "Varna")
            {
                if (product == "coffee")
                {
                    totalPrice = quantity * 0.45;
                }
                else if (product == "water")
                {
                    totalPrice = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    totalPrice = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    totalPrice = quantity * 1.35;
                }
                else
                {
                    totalPrice = quantity * 1.55;
                }
            }

            Console.WriteLine(totalPrice);

        }
    }
}
