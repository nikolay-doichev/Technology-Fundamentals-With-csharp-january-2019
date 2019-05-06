using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];

            int[] secondArray = new int[n];

            for (int rotation = 0; rotation < n; rotation++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (rotation%2==0)
                {
                    firstArray[rotation] = numbers[0];
                    secondArray[rotation] = numbers[1];
                }
                else
                {
                    firstArray[rotation] = numbers[1];
                    secondArray[rotation] = numbers[0];
                }
            }
            string newFirstString = string.Join(' ', firstArray);
            string newSecondString = string.Join(' ', secondArray);

            Console.WriteLine(newFirstString);
            Console.WriteLine(newSecondString);
        }
    }
}
