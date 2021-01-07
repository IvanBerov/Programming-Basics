using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double averageGrade = 0.0;
            int gradeFail = 0;
            double gredeGraduated = 0.0;
            int grade = 1 ; 

            while (true)
            {
                
                double gradeForYear = double.Parse(Console.ReadLine());

                if (gradeForYear < 4)
                {
                    gradeFail++;

                    if (gradeFail == 2)
                    {
                        grade--;
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }
           
                else
                {
                    gredeGraduated += gradeForYear;

                    if (grade == 12)
                    {
                        averageGrade = gredeGraduated / 12.0;
                        Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
                        break;
                    }

                }
                grade++;

            }
        }
    }
}
