﻿using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter<=10)
            {
                Console.WriteLine($"{n} X {counter} = {n*counter}");
                counter++;
            }
        }
    }
}
