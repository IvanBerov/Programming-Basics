using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int number = i;
                int evenSum = 0;
                int oddSum = 0;

                // vzimame 4isla na 4etni i ne4etni pozicii 
                // davame nasoki 4rez bool promenliva

                bool isEvenPosition = true;

                while (number > 0)
                {
                    int lastDigit = number % 10;

                    if (isEvenPosition)
                    {
                        evenSum += lastDigit;
                        isEvenPosition = false;
                    }
                    else
                    {
                        oddSum += lastDigit;
                        isEvenPosition = true;
                    }
                    number /= 10;
                }
                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
