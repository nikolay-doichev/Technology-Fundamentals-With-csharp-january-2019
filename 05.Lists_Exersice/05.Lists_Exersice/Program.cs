using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Lists_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonAndPassengers = Console.ReadLine()
                                                  .Split()
                                                  .Select(int.Parse)
                                                  .ToList();
            int maxPassengers = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] newWaggons = command.Split().ToArray();
                if (command.Length > 2)
                {
                    int newPassengersAndWaggon = int.Parse(newWaggons[1]);
                    wagonAndPassengers.Add(newPassengersAndWaggon);
                }
                else
                {
                    int addingPassengers = int.Parse(command);
                    for (int index = 0; index < wagonAndPassengers.Count-1; index++)
                    {
                        if ((addingPassengers + wagonAndPassengers[index]) <= maxPassengers)
                        {
                            wagonAndPassengers[index] = addingPassengers + wagonAndPassengers[index];
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', wagonAndPassengers));
        }
    }
}
