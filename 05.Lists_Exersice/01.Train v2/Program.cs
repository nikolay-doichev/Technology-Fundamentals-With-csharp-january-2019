using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();
            int capacityOfWagon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command!="end")
            {
                List<string> direction = command.Split().ToList();

                if (direction[0]=="Add")
                {
                    int customersInWagons = int.Parse(direction[1]);
                    wagons.Add(customersInWagons);
                }
                else
                {
                    int passengersToFit = int.Parse(direction[0]);
                    for (int index = 0; index < wagons.Count; index++)
                    {
                        if (wagons[index]+passengersToFit<=capacityOfWagon)
                        {
                            wagons[index] += passengersToFit;
                            break;
                        }
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',wagons));
        }
    }
}
