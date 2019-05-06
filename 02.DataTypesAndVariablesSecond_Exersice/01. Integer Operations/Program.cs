using System;

namespace Second_Exersice_Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirtNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sum = ((firstNumber+secondNumber)/thirtNumber)*fourthNumber;
            Console.WriteLine(sum);
        }
    }
}
