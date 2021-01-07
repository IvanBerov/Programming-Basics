using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                int curNum = int.Parse(Console.ReadLine());
                sum += curNum;
            }
            Console.WriteLine(sum);
        }
    }
}
