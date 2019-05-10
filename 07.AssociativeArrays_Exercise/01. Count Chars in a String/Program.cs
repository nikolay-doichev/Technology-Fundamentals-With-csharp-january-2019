using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            string command = Console.ReadLine();
            
            while (command!="stop")
            {
                string currentResource = command;
                command = Console.ReadLine();
                int resourceQuantity = int.Parse(command);
                if (!resources.ContainsKey(currentResource))
                {                    
                    resources.Add(currentResource, resourceQuantity);
                }
                else
                {
                    resources[currentResource] += resourceQuantity;
                }
                command = Console.ReadLine();
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
