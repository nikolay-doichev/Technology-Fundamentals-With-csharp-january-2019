using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double volume = 0;
            double maxVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string Keg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());
                volume = Math.PI * radiusOfKeg * radiusOfKeg * heightOfKeg;

                if (volume>maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = Keg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
