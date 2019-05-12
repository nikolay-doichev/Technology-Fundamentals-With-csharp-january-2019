using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] valuesAsString = values.Split();
            double[] numbers = new double[valuesAsString.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(valuesAsString[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(numbers[i]):F0}");
            }
        }
    }
}
