using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberLenght = number.ToString();
            int sumNumbers = 0;

            for (int i = 0; i < numberLenght.Length; i++)
            {
                sumNumbers += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}
