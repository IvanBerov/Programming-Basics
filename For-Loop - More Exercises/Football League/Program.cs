using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityOfStadium = int.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());

            int countA = 0;
            int countB = 0;
            int countV = 0;
            int countG = 0;

            for (int i = 0; i < numberOfFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    countA++;
                }
                else if (sector == "B")
                {
                    countB++;
                }
                else if (sector == "V")
                {
                    countV++;
                }
                else
                {
                    countG++;
                }
            }
            double precentA = (countA*1.0 / numberOfFans) * 100;
            double precentB = (countB*1.0 / numberOfFans) * 100;
            double precentV = (countV*1.0 / numberOfFans) * 100;
            double precentG = (countG*1.0 / numberOfFans) * 100;
            double precentAll = (numberOfFans * 1.0 / capacityOfStadium) * 100;

            Console.WriteLine($"{precentA:f2}%");
            Console.WriteLine($"{precentB:f2}%");
            Console.WriteLine($"{precentV:f2}%");
            Console.WriteLine($"{precentG:f2}%");
            Console.WriteLine($"{precentAll:f2}%");
        }
    }
}
