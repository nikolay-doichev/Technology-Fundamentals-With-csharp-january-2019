using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split();
            Array.Reverse(items);
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
        }
    }
}
