using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            string command = Console.ReadLine();

            while (command!="end")
            {
                List<string> direction = command.Split().ToList();
                if (direction[0]=="Delete")
                {
                    int elementForDelete = int.Parse(direction[1]);
                    while (numbers.Contains(elementForDelete))
                    {
                        numbers.Remove(elementForDelete);
                    }                    
                }
                else if (direction[0]=="Insert")
                {
                    int element = int.Parse(direction[1]);
                    int position = int.Parse(direction[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
