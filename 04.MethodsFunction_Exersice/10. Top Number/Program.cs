using System;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SumCanDivadeByEight(n);
        }

        private static void SumCanDivadeByEight(int n)
        {
            int sum = 0;
            for (int index = 0; index < n; index++)
            {
                bool isItOdd =false;
                bool isItDevideByEught = false;
                int currentNumber = index;
                while (currentNumber>0)
                {
                    int lastNumber = currentNumber % 10;
                    if (lastNumber%2==1)
                    {
                        isItOdd = true;
                    }
                    sum += lastNumber;
                    currentNumber /= 10;
                }
                if (sum%8==0)
                {
                    isItDevideByEught = true;
                }
                if (isItOdd && isItDevideByEught)
                {
                    Console.WriteLine(index);
                }
                sum = 0;
            }
        }
    }
}
