using System;
using System.Linq;

namespace _02.Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            int initailHeath = 100;
            int initailCoins = 0;

            for (int index = 0; index < rooms.Length; index++)
            {
                string[] currentRoom = rooms[index].Split(' ').ToArray();
                string command = currentRoom[0];
                int number = int.Parse(currentRoom[1]);

                if (command == "potion")
                {
                    int currentHealth = initailHeath;
                    initailHeath += number;

                    if (initailHeath > 100)
                    {
                        Console.WriteLine($"You healed for {100 - currentHealth} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        initailHeath = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initailHeath} hp.");
                    }
                }

                else if (command == "chest")
                {
                    initailCoins += number;
                    Console.WriteLine($"You found {number} coins.");
                }

                else //monster
                {
                    string monster = command;
                    initailHeath -= number;
                    if (initailHeath>0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {index+1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {initailCoins}");
            Console.WriteLine($"Health: {initailHeath}");
        }
    }
}
