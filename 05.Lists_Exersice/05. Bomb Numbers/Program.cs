using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            List<int> bomb = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            for (int index = 0; index < numbers.Count-1; index++)
            {
                if (numbers[index] == bomb[0])                    
                {
                    for (int i = bomb[1]; i >= 1; i--)
                    {                        
                        numbers.RemoveAt(index - 1);
                        index--;
                    }
                    if (index+bomb[1] > numbers.Count-1)
                    {
                        int difference = numbers.Count - index;
                        numbers.RemoveRange(index,difference);
                    }
                    else
                    {
                        numbers.RemoveRange(index, bomb[1] + 1);
                    }
                    
                }

            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
