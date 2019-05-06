using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            List<string> singleLetters = new List<string>();
            

            //aaaaabbbbbcdddeeeedssaa
            //abcdedsa
            for (int index = 0; index < letters.Length; index++)
            {
                string currentChar = letters[index].ToString();
                if (index+1==letters.Length)
                {
                    singleLetters.Add(currentChar);
                    break;
                }
                string nextChar = letters[index + 1].ToString();
                if (currentChar != nextChar)
                {
                    singleLetters.Add(currentChar);
                }

            }
            foreach (var item in singleLetters)
            {
                Console.Write(item);
            }
        }
    }
}
