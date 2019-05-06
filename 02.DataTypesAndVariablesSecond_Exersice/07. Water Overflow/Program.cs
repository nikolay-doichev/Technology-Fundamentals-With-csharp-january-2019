using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            
            int tankMaxVolume = 255;
            int sumOfLitersInTank = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                sumOfLitersInTank += quantities;
                if (sumOfLitersInTank>tankMaxVolume || quantities>tankMaxVolume)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumOfLitersInTank -= quantities;
                }                            
                
            }
            Console.WriteLine(sumOfLitersInTank);
        }
    }
}
