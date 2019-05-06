using System;

namespace Exercises_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] people = new int[numberOfWagons];
            int sum = 0;

            for (int index = 0; index < people.Length; index++)
            {
                people[index] = int.Parse(Console.ReadLine());
                sum += people[index];
            }
            string value = string.Join(' ', people);
            Console.WriteLine(value);
            Console.WriteLine(sum);
        }
    }
}
