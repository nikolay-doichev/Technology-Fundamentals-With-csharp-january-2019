using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameForCount = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCount(nameForCount));
        }

        private static int VowelsCount(string nameForCount)
        {
            int count = 0;
            string iput = nameForCount.ToLower();
            for (int index = 0; index < nameForCount.Length; index++)
            {
                if (nameForCount[index] == 'a' ||
                    nameForCount[index] == 'y' ||
                    nameForCount[index] == 'o' ||
                    nameForCount[index] == 'u' ||
                    nameForCount[index] == 'e' ||
                    nameForCount[index] == 'i')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
