using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesInHour = double.Parse(Console.ReadLine());
            int daysNumber = int.Parse(Console.ReadLine());

            double totalTimeToRead = numberOfPages / pagesInHour;
            double hoursPerDay = totalTimeToRead / daysNumber;

            Console.WriteLine(hoursPerDay);


        }
    }
}
