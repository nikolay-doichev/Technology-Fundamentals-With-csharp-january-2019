﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
 
namespace NewSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}