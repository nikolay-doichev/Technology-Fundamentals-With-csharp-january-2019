using System;

namespace DemoExam_02._03._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studnets = int.Parse(Console.ReadLine());
            double priceOfPackageFlour = double.Parse(Console.ReadLine());
            double priceOfEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());
            int freeFlour = studnets / 5;
            double purchase = Math.Round(Math.Ceiling(studnets+studnets*0.2)*priceOfApron +studnets*(priceOfEgg*10)+priceOfPackageFlour*(studnets-freeFlour),2);

            if (purchase<=budget)
            {
                Console.WriteLine($"Items purchased for {purchase:F2}$.");
            }
            else
            {
                Console.WriteLine($"{purchase-budget:F2}$ more needed.");
            }
        }
    }
}
