using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 1;
            int topInteger = 0;
            int maxIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {

                    count++;
                    if (count > topInteger)
                    {
                        maxIndex = i + 1;
                        topInteger = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = maxIndex; i > maxIndex - topInteger; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}