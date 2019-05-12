using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                int currentNumber = numbers[index];

                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
