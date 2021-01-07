using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            int sumPrime = 0;
            int noPrime = 0;

            while (comand != "stop")
            {
                int number = int.Parse(comand);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                int count = 0; //broi na deliteli

                    for (int i = 1; i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        sumPrime += number;
                    }
                    else if (count > 2)
                    {
                        noPrime += number;
                    }                   
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {noPrime}");
        }
    }
}
