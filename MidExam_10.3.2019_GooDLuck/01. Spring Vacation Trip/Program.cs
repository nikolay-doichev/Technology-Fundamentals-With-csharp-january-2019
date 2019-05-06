using System;

namespace MidExam_10._3._2019_GooDLuck
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfVacantion = int.Parse(Console.ReadLine());
            double budgetOfGroup = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodForPersen = double.Parse(Console.ReadLine());
            double priceForHotel = double.Parse(Console.ReadLine());

            double expensesDiscount = 0;
            double hotelDiscount = 0;
            double expenses = foodForPersen * groupOfPeople * daysOfVacantion +
                              priceForHotel * groupOfPeople * daysOfVacantion;
            if (groupOfPeople > 10)
            {
                hotelDiscount = priceForHotel * groupOfPeople * daysOfVacantion * 0.25;
                expenses -= hotelDiscount;
            }

            for (int index = 1; index <= daysOfVacantion; index++)
            {
                double travellingDistance = double.Parse(Console.ReadLine());

                expenses += travellingDistance * fuelPerKilometer;
                if (index % 3 == 0 || index % 5 == 0)
                {
                    double additionlExpenses = expenses * 0.4;
                    expenses = expenses+additionlExpenses;
                }
                if (index % 7 == 0)
                {
                    expensesDiscount = expenses / groupOfPeople;
                    expenses = expenses - expensesDiscount;
                }
                if (expenses > budgetOfGroup)
                {
                    break;
                }
            }

            if (budgetOfGroup >= expenses)
            {
                Console.WriteLine($"You have reached the destination. You have {(budgetOfGroup - expenses):f2}$ budget left.");
            }
            else
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {(expenses - budgetOfGroup):f2}$ more.");
            }
        }
    }
}
