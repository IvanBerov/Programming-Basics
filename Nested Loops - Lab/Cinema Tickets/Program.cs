using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int totalPeopleCount = 0;
            int countPerMovie = 0;

            int standardCount = 0;
            int studentCount = 0;
            int kidCount = 0;
            
            while (movieName != "Finish")
            {
               int freeSpace = int.Parse(Console.ReadLine());

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command != "End")
                    {
                        totalPeopleCount++;
                        countPerMovie++;
                    }
                 
                    if (command == "standard")
                    {
                        standardCount++;
                    }
                    else if (command == "student")
                    {
                        studentCount++;
                    }
                    else if (command == "kid")
                    {
                        kidCount++;
                    }
                    if (command == "End"|| countPerMovie == freeSpace)
                    {
                        double precentPerFilm = (countPerMovie * 1.0) / freeSpace * 100;
                        Console.WriteLine($"{movieName} - {precentPerFilm:f2}% full.");
                        break;
                    }
                }
                countPerMovie = 0;
                movieName = Console.ReadLine();     
            }

            double studentPrecent = (studentCount * 1.0) / totalPeopleCount * 100;
            double standardPrecent = (standardCount * 1.0) / totalPeopleCount * 100;
            double kidPrecent = (kidCount * 1.0) / totalPeopleCount * 100;

            Console.WriteLine($"Total tickets: {totalPeopleCount}");
            Console.WriteLine($"{studentPrecent:f2}% student tickets.");
            Console.WriteLine($"{standardPrecent:f2}% standard tickets.");
            Console.WriteLine($"{kidPrecent:f2}% kids tickets.");
        }
    }
}
