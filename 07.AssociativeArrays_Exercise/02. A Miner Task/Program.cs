using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AssociativeArrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var counterOfCharacters = new Dictionary<char, int>();

            var words = Console.ReadLine().Split(' ').ToList();

            for (int index = 0; index < words.Count; index++)
            {
                string currentWord = words[index];
                for (int index2 = 0; index2 < currentWord.Length; index2++)
                {
                    char currentChar = currentWord[index2];

                    if (!counterOfCharacters.ContainsKey(currentChar))
                    {
                        counterOfCharacters.Add(currentChar, 1);
                    }
                    else
                    {                        
                        counterOfCharacters[currentChar] += 1;
                    }
                }
            }
            foreach (var item in counterOfCharacters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
