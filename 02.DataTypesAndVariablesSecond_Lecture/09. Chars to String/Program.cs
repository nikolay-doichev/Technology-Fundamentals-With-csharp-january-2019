using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string combine = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                combine += symbol;
            }
            Console.WriteLine(combine);
        }
    }
}
