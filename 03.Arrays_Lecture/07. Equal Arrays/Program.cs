using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int arraySum = 0;
            bool areEqual = false;

            for (int index = 0; index < arr1.Length; index++)
            {
                if (arr1[index] != arr2[index])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    areEqual = false;
                    break;
                }
                else
                {
                    arraySum += arr1[index];
                    areEqual = true;
                }
            }
            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
            }
        }
    }
}
