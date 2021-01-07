using System;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
            }
        }
    }
}
//  string input = Console.ReadLine();
//  while(input != "Stop" )
//  {
//     Console.WriteLine(input);
//     input = Console.ReadLine();
//  }