using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsePrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = 0;            

            for (int i = 1; i <= lostGames; i++)
            {
                if (i%12==0)
                {
                    money += displayPrice;
                }
                if (i%6==0)
                {
                    money += keyboardPrice;
                }
                
                if (i%2==0)
                {
                    money += headsePrice;
                }
                if (i%3==0)
                {
                    money += mousePrice;
                }
            }
            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
