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

            while (command != "End")
            {
                List<string> direction = command.Split().ToList();
                if (direction[0] == "Add")
                {
                    int elementToAdd = int.Parse(direction[1]);
                    numbers.Add(elementToAdd);
                }
                else if (direction[0] == "Insert")
                {
                    int number = int.Parse(direction[1]);
                    int index = int.Parse(direction[2]);
                    if (index>=numbers.Count || index<0)
                    {
                        Console.WriteLine("Invalid index");                        
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }                    
                }
                else if (direction[0] == "Remove")
                {
                    int indexForRemove = int.Parse(direction[1]);
                    if (indexForRemove >= numbers.Count || indexForRemove < 0)
                    {
                        Console.WriteLine("Invalid index");                        
                    }
                    else
                    {
                        numbers.RemoveAt(indexForRemove);
                    }
                    
                }

                else if (direction[1] == "left")
                {
                    int count = int.Parse(direction[2]);
                    for (int index = 0; index < count; index++)
                    {
                        numbers.Add(numbers[0]);

                        numbers.RemoveAt(0);
                    }
                }
                else if (direction[1] == "right")
                {
                    int count = int.Parse(direction[2]);
                    for (int index = 0; index < count; index++)
                    {
                        numbers.Insert(0,numbers[numbers.Count-1]);
                        
                        numbers.RemoveAt(numbers.Count-1);
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
