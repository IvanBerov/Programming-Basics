using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int strNum = int.Parse(Console.ReadLine());
            int finNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinations = 0;
            bool found = false;

            for (int x1 = strNum; x1 <= finNum; x1++)
            {
                for (int x2 = strNum; x2 <= finNum; x2++)
                {
                    combinations++;
                    if (x1 + x2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNum})");
                        found = true;
                        break;
                    }

                }
                if (found)
                {
                    break;
                }

            }
            if (!found)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");

            }
        }
    }
}
