using System;

namespace Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int rowsFirstSectorA = int.Parse(Console.ReadLine());
            int oddRowsSeat = int.Parse(Console.ReadLine());

            int factor = 0;
            int counter = 0;

            for (char i = 'A'; i <= symbol; i++,rowsFirstSectorA++)
            {
                for (int j = 1; j <= rowsFirstSectorA; j++)
                {
                    factor = (j % 2 == 0) ? 2 : 0;

                    for (char k = 'a'; k < 'a' + oddRowsSeat + factor; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                        counter++;
                        

                    }
                   
                }
            }
            Console.WriteLine(counter);
            //Да се отпечата на конзолата всяко място на отделен ред по следния формат:
            //{ сектор}{ ред}{ място}
            //Накрая трябва да отпечата броя на всички места. 
        }
    }
}
