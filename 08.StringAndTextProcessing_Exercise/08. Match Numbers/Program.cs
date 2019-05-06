using System;
using System.Text.RegularExpressions;

namespace _08._Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=[\s]))-?\d+(\.\d+)?($|(?=[\s]))";
            string names = Console.ReadLine();
            MatchCollection matched = Regex.Matches(names, regex);

            foreach (var name in matched)
            {
                Console.Write(name + " ");
            }

        }
    }
}
