using System;

namespace _02.First_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //5 101 0
            //3 011 1

           n = n >> 1;

            Console.WriteLine(n & 1);
        }
    }
}
