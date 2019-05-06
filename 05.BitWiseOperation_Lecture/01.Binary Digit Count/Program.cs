using System;

namespace _05.BitWiseOperation_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bitToFind = int.Parse(Console.ReadLine());
            int counter = 0;


            while (number>0)
            {
                int reminder = number % 2;
                if (reminder==bitToFind)
                {
                    counter++;
                }
                number /= 2;
            }
            Console.WriteLine(counter);
            string numbers = Console.ReadLine();
            
        }
    }
}
