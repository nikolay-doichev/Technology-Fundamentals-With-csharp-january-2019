using System;
using System.Linq;

namespace _02._Bread_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] order = Console.ReadLine().Split('|').ToArray();
            int initialEnergy = 100;
            int initialCoins = 100;

            for (int index = 0; index < order.Length; index++)
            {
                string[] commandLine = order[index].Split('-').ToArray();
                string command = commandLine[0];
                int number = int.Parse(commandLine[1]);

                if (command == "rest")
                {
                    int currentEnergy = initialEnergy;
                    initialEnergy += number;
                    if (initialEnergy > 100)
                    {
                        Console.WriteLine($"You gained {100 - currentEnergy} energy.");
                        Console.WriteLine("Current energy: 100.");
                        initialEnergy = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {initialEnergy}.");
                    }
                }
                else if (command == "order")
                {        
                    //order-10
                    if (initialEnergy-30 >= 0) //obarkano:bqh napisal "initialEnergy-number" i taka polu4avah 
                                               //dali ako ot energiqta izvadq PARITE shte moga da q izvyrsha
                                               // a trqbwa da proverq dali ako ot energiqta izvadq 30!!!
                    {
                        initialEnergy -= 30;
                        initialCoins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        initialEnergy += 50;                        
                    }
                }
                else
                {                    
                    if (initialCoins-number>0)
                    {
                        Console.WriteLine($"You bought {command}.");
                        initialCoins -= number;
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        return;
                    }
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {initialCoins}");
            Console.WriteLine($"Energy: {initialEnergy}");
        }
    }
}
