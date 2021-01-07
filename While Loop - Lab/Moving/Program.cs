using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int appartment = width * lenght * hight;
            bool appVolume = true;

            string command = Console.ReadLine();

            while (!(command=="Done"))
            {
                int box = int.Parse(command);
                appartment -= box;

                if (appartment < 0)
                {
                    appVolume = false;
                    break;
                }
                command = Console.ReadLine();
            }
            if (appVolume)
            {
                Console.WriteLine($"{appartment} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(appartment)} Cubic meters more.");
            }



        }
    }
}
