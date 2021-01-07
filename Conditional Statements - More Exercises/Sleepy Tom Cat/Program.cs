using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int normTomGame = 30000;
            int workingDays = 365 - daysOff;
            int timePlayWorkDay = workingDays * 63;
            int timePlayOffDay = daysOff * 127;
            int totalTimeToPlay = timePlayOffDay + timePlayWorkDay;

            //Ако времето за игра на Том е над нормата за текущата година: 
            // На първия ред отпечатайте: “Tom will run away” 
            //На втория ред отпечатайте разликата от нормата във формат:
            //“{ H}hours and { M}minutes more for play” 
            if (totalTimeToPlay > normTomGame)
            {
                int moreTime = totalTimeToPlay - normTomGame;
                int hour = moreTime / 60;
                int min = moreTime % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hour} hours and {min} minutes more for play");

            }
            //Ако времето за игра на Том е под нормата за текущата година: 
            //На първия ред отпечатайте: “Tom sleeps well” 
            //На втория ред отпечатайте разликата от нормата във формат:
            //“{ H}hours and { M}minutes less for play”
            else if (totalTimeToPlay < normTomGame)
            {
                int lessTime = normTomGame - totalTimeToPlay;
                int hour = lessTime / 60;
                int min = lessTime % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {min} minutes less for play");
            }
        }
    }
}
