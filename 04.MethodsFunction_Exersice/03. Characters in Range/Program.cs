using System;
namespace asda
{
    class Program
    {
        public static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            CharactersInRange(start, end);



        }
        static void CharactersInRange(int start, int end)
        {
            string charRow = string.Empty;
            for (int i = (char)start + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

            if (start > end)
            {
                for (int i = (char)end + 1; i < start; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}