using System;

namespace Methods_Function_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            SmallestOfThreeNumbers(firstNumber,secondNumber,lastNumber);
            
        }

        static int SmallestOfThreeNumbers(int firstNumber, int secondNumber, int lastNumber)
        {            
            if (firstNumber<secondNumber && firstNumber<lastNumber)
            {
                return firstNumber;
            }
            else if (secondNumber<firstNumber && secondNumber<lastNumber)
            {
                return secondNumber;
            }
            else
            {
                return lastNumber;
            }            
        }
    }
}
