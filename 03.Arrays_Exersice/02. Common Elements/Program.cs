using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();
            string equalStrings = string.Empty;

            for (int index2 = 0; index2 < secondArray.Length; index2++)
            {
                for (int index1 = 0; index1 < firstArray.Length; index1++)
                {
                    if (firstArray[index1] == secondArray[index2])
                    {
                        equalStrings += firstArray[index1] + " ";
                    }
                }
            }
            Console.WriteLine(equalStrings);

        }
    }
}

