using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char exceptLetter = char.Parse(Console.ReadLine());

            int charSum = 0;

            for (char first = startLetter; first <= endLetter; first++)
            {
                for (char second = startLetter; second <= endLetter; second++)
                {
                    for (char third = startLetter; third <= endLetter; third++)
                    {
                        if (first != exceptLetter && second != exceptLetter && third != exceptLetter)
                        {
                            charSum++;
                            Console.Write($"{first}{second}{third} ");
                        }
                    }
                }
            }
            Console.WriteLine(charSum);
        }
    }
}
