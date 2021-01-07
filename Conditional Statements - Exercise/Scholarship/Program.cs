using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Round(minSalary * 0.35);
            double excellentSuccessScholarship = Math.Round(averageGrade * 25);


            if (averageGrade >= 5.50 && income < minSalary && excellentSuccessScholarship >= socialScholarship)

            {

                Console.WriteLine($"You get a scholarship for excellent results {excellentSuccessScholarship} BGN");

            }

            else if (averageGrade >= 5.50 && income < minSalary && excellentSuccessScholarship < socialScholarship)

            {

                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");

            }

            else if (averageGrade >= 5.50)

            {

                Console.WriteLine($"You get a scholarship for excellent results {excellentSuccessScholarship} BGN");

            }

            else if (income < minSalary && averageGrade > 4.50)

            {

                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");

            }

            else

            {

                Console.WriteLine("You cannot get a scholarship!");

            }

        }
    }
}

