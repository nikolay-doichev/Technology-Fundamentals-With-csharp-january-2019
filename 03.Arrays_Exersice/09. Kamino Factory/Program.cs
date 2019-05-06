using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int longestSubsequence = -1;
            int longestSubindex = -1;
            int longestSubSum = -1;
            int indexOfLongest = 0;
            int[] sequence = new int[lenght];

            string input = Console.ReadLine();

            int indexOfSequence = 1;

            while (input!= "Clone them!")
            {
                int[] curuntSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
                int Subsequence = 0;
                int Subindex = -1;
                int SubSum = 0;

                int count = 0;
                for (int i = 0; i < lenght; i++)
                {
                    if (curuntSequence[i]==1)
                    {
                        count++;
                        SubSum++;
                        if (count>Subsequence)
                        {
                            Subsequence = count;
                            Subindex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if (Subsequence>longestSubsequence)
                {
                    longestSubindex = Subindex;
                    longestSubsequence = Subsequence;
                    longestSubSum = SubSum;
                    sequence = curuntSequence;
                    indexOfLongest = indexOfSequence;
                }
                else if (Subsequence == longestSubsequence 
                    && longestSubindex>Subindex )
                {
                    longestSubindex = Subindex;                    
                    longestSubSum = SubSum;
                    sequence = curuntSequence;
                    indexOfLongest = indexOfSequence;
                }
                else if (Subsequence == longestSubsequence
                    && longestSubindex == Subindex 
                    && longestSubSum<SubSum)
                {
                    longestSubSum = SubSum;
                    sequence = curuntSequence;
                    indexOfLongest = indexOfSequence;
                }
                indexOfSequence++;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSubSum}.");
            Console.WriteLine(string.Join(' ',sequence));
        }
    }
}
