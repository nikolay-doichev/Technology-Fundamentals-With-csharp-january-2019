using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            FactorialFirstNumber(firstNumber);
            FactorialSecondNumber(secondNumber);

            double division = FactorialFirstNumber(firstNumber) / FactorialSecondNumber(secondNumber);
            Console.WriteLine($"{division:F2}");
        }

        private static double FactorialSecondNumber(double secondNumber)
        {
            double secondFactorial = 1;
            for (double i = secondNumber; i > 0; i--)
            {
                secondFactorial *= secondNumber;
                secondNumber--;
            }
            return secondFactorial;
        }

        private static double FactorialFirstNumber(double firstNumber)
        {
            double firstFactorial = 1;
            for (double i = firstNumber; i > 0; i--)
            {
                firstFactorial *= firstNumber;
                firstNumber--;
            }
            return firstFactorial;
        }
    }
}
