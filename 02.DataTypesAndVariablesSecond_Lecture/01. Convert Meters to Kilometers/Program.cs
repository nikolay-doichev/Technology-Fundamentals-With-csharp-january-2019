using System;

namespace secondLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            double meter = double.Parse(Console.ReadLine());
            double kilometers = meter / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
