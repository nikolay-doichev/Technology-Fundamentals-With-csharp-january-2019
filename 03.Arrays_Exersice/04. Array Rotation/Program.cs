using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = new int[arrayOne.Length];

            int rotation = int.Parse(Console.ReadLine());

            for (int index = 0; index < arrayOne.Length; index++)
            {
                if (rotation>arrayOne.Length)
                {
                    rotation -= arrayOne.Length;
                }
                int newPosition = index+rotation;
                if (newPosition > arrayOne.Length - 1)
                {
                    newPosition =index+rotation-arrayOne.Length;
                }
                
                
                arrayTwo[index] = arrayOne[newPosition];
            }
            string finalResult = string.Join(' ', arrayTwo);
            Console.WriteLine(finalResult);
        }
    }
}
