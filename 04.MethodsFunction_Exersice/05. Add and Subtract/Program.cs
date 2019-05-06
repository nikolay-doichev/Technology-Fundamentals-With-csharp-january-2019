using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirtNumber = int.Parse(Console.ReadLine());

            SumIntegers(firstNumber, secondNumber);
            Substract(thirtNumber);
            int result = SumIntegers(firstNumber,secondNumber) + Substract(thirtNumber);
            Console.WriteLine(result);
        }

        private static int Substract(int thirtNumber)
        {
            int substract = 0;
            substract -= thirtNumber;
            return substract;
        }

        private static int SumIntegers(int firstNumber, int secondNumber)
        {
            int sum = 0;
            sum = firstNumber + secondNumber;
            return sum;
        }
    }
}
