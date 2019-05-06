using System;
using System.Linq;

namespace _05._Top_Integers_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            int sumLeft = 0;
            int sumRight = 0;
            int indexValue = 0;
            int counter = 1;

            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            else if (numbers.Length == 2)
            {
                Console.WriteLine("no");
                return;
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                
                for (int indexLeft = index; indexLeft > 0; indexLeft--)
                {
                    sumLeft += numbers[index-counter];
                    counter++;
                }
                counter = 1;
                for (int indexright = index; indexright < numbers.Length-1; indexright++)
                {
                    sumRight += numbers[index + counter];
                    counter++;
                }
                counter = 1;
                if (sumLeft== sumRight)
                {
                    indexValue = index;
                    Console.WriteLine(indexValue);
                    return;
                }
                sumLeft = 0;
                sumRight = 0;
            }
            Console.WriteLine("no");
        }
    }
}
