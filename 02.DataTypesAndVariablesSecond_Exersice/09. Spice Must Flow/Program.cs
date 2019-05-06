using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int counter = 0;

            while (startingYield >= 100)
            {
                totalAmount += startingYield - 26;
                startingYield -= 10;
                counter++;
            }

            if (totalAmount >= 26)
            {
                totalAmount -= 26;
            }

            Console.WriteLine(counter);
            Console.WriteLine(totalAmount);

        }
    }
}
