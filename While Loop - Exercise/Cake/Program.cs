using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int torteSize = width * lenght;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
               int slice = int.Parse(command);
                torteSize -= slice;
                

                if (torteSize <= 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            string result = string.Empty;

            if (torteSize > 0)
            {
                result = $"{torteSize} pieces are left.";
            }
            else
            {
                result = $"No more cake left! You need {Math.Abs(torteSize)} pieces more.";
            }

            Console.WriteLine(result);
        }
    }
}
