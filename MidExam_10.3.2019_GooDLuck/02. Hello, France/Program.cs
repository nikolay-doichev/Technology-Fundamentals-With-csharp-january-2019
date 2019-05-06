using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] triftShop = Console.ReadLine().Split('|').ToArray();
            double leftBudget = double.Parse(Console.ReadLine());
            List<double> newItemsPrice = new List<double>();
            double newSellingPrice = 0;
            double profit = 0;
            double allProfit = 0;

            double limitClothes = 50.00;
            double limitShoes = 35.00;
            double limitAccessories = 20.50;

            for (int index = 0; index < triftShop.Length; index++)
            {
                //Clothes->43.30|Shoes->25.25|Clothes->36.52|Clothes->20.90|Accessories->15.60
                string[] purchase = triftShop[index].Split("->").ToArray();
                string item = purchase[0];
                double priceOfitem = double.Parse(purchase[1]);                

                //Clothes->43.30
                if (item== "Clothes")
                {
                    if (priceOfitem<=limitClothes && leftBudget>=priceOfitem)
                    {
                        leftBudget -= priceOfitem;
                        newSellingPrice = priceOfitem * 1.4;
                        allProfit += newSellingPrice;
                        profit += newSellingPrice - priceOfitem;
                        newItemsPrice.Add(newSellingPrice);
                    }                    
                }
                //Shoes->25.25
                else if (item == "Shoes")
                {
                    if (priceOfitem <= limitShoes && leftBudget >= priceOfitem)
                    {
                        leftBudget -= priceOfitem;
                        newSellingPrice = priceOfitem * 1.4;
                        allProfit += newSellingPrice;
                        profit += newSellingPrice - priceOfitem;
                        newItemsPrice.Add(newSellingPrice);
                    }
                }
                //Accessories->15.60
                else if (item == "Accessories")
                {
                    if (priceOfitem <= limitAccessories && leftBudget >= priceOfitem)
                    {
                        leftBudget -= priceOfitem;
                        newSellingPrice = priceOfitem * 1.4;
                        allProfit += newSellingPrice;
                        profit += newSellingPrice - priceOfitem;
                        newItemsPrice.Add(newSellingPrice);
                    }
                }
            }
            if (allProfit+leftBudget>=150)
            {
                foreach (var item in newItemsPrice)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:f2}");
                Console.WriteLine("Hello, France!");
            }
            else
            {
                foreach (var item in newItemsPrice)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Profit: {profit:f2}");
                Console.WriteLine("Time to go.");
            }
        }
    }
}
