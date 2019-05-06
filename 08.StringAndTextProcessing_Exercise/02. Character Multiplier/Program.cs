using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringsForSum = Console.ReadLine().Split(' ');
            string firstString = stringsForSum[0];
            string secondString = stringsForSum[1];

            int firstStringSum = 0;
            foreach (var item in firstString)
            {
                firstStringSum += item;
            }

            int secondStringSum = 0;
            foreach (var item in secondString)
            {
                secondStringSum += item;
            }

            int totalSum = 0;
            //Gosho Pesho
            if (firstString.Length>=secondString.Length)
            {
                for (int index = 0; index < secondString.Length; index++)
                {
                    //Gosho
                    int firstDigit = firstString[index];
                    int secondDigit = secondString[index];                 
                    
                    totalSum += firstDigit*secondDigit;
                }
                for (int index2 = secondString.Length; index2 < firstString.Length; index2++)
                {
                    totalSum += firstString[index2];
                }
            }
            else
            {
                for (int index = 0; index < firstString.Length; index++)
                {
                    int firstDigit = firstString[index];
                    int secondDigit = secondString[index];

                    totalSum += firstDigit * secondDigit;
                }
                for (int index2 = firstString.Length; index2 < secondString.Length; index2++)
                {
                    totalSum += secondString[index2];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
