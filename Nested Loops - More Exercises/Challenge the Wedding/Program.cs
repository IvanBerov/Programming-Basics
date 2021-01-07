using System;
using System.ComponentModel.Design;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int man = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int table = int.Parse(Console.ReadLine());

            int tableCount = 0;

            for (int m = 1; m <= man; m++)
            {
                for (int f = 1; f <= woman; f++)
                {
                    Console.Write($"({m} <-> {f}) ");

                    tableCount++;

                    if (tableCount == table)
                    {
                        return;
                    }
                }
            }
        }
    }
}
