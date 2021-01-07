using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNum = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleFoodKg = double.Parse(Console.ReadLine());

            double totalFoodKg = (dogFoodKg * dayNum) + (catFoodKg * dayNum) + ((turtleFoodKg / 1000) * dayNum);

            if (totalFoodKg <= foodKg)
            {
                double foodLeft =Math.Floor(foodKg - totalFoodKg);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else if (totalFoodKg > foodKg)
            {
                double neededFood = Math.Ceiling(totalFoodKg - foodKg);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
