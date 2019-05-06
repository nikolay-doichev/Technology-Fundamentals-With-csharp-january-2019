using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNumber = number;
            int sumNumber = 1;
            int lastDigit = 0;
            int sumAllNumbers = 0;

            while (number>0)
            {
                lastDigit = number % 10;
                sumNumber = 1;
                while (lastDigit>1)
                {
                    sumNumber *= lastDigit;
                    lastDigit -= 1;
                }
                sumAllNumbers +=sumNumber;                
                number = number / 10;  
            }
            if (sumAllNumbers==firstNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
