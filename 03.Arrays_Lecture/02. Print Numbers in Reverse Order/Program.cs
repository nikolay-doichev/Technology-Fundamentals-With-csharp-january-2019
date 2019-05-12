using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < n; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
