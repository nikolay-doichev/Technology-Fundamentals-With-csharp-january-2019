using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> batchesOfBread = new List<string>();
            int currenetSum = 0;
            int biggestSum = 0;
            double averageCurrentNumber = 0;
            double averageBiggestSum = 0;
            int bestBread = 0;
            //5#4#10#-2
            //10#5#2#3#2
            //Bake It!

            while (!batchesOfBread.Contains("Bake It!"))
            {
                List<string> oneBatchesofBread = Console.ReadLine().Split('#').ToList();
                batchesOfBread.Add(string.Join(" ", oneBatchesofBread));
            }
            batchesOfBread.RemoveAt(batchesOfBread.Count - 1);

            for (int index = 0; index < batchesOfBread.Count; index++)
            {
                string currentNumber = batchesOfBread[index];
                for (int word = 0; word < batchesOfBread[index].Length; word++)
                {
                    int number = (int)Char.GetNumericValue(currentNumber[word]);
                    currenetSum += number;
                }
                if (currenetSum >= biggestSum)
                {
                    if (currenetSum == biggestSum)
                    {
                        averageCurrentNumber = currenetSum / currentNumber.Length;
                        averageBiggestSum = biggestSum / currentNumber.Length;
                        if (averageCurrentNumber >= averageBiggestSum)
                        {
                            if (averageCurrentNumber == averageBiggestSum)
                            {
                                if (batchesOfBread[index - 1].Length>currentNumber.Length)
                                {
                                    bestBread = int.Parse(batchesOfBread[index - 1]);
                                }
                                else
                                {
                                    bestBread = int.Parse(currentNumber);
                                }
                            }
                            bestBread = int.Parse(batchesOfBread[index - 1]);
                        }
                        else
                        {
                            bestBread = int.Parse(currentNumber);
                        }
                        biggestSum = currenetSum;

                    }

                }
            }

            Console.WriteLine(bestBread);
        }
    }
}
