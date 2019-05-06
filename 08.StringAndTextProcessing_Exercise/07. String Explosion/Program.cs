using System;

namespace StringExplosion
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol.Equals('>'))
                {
                    int currentStrength = int.Parse(text[i + 1].ToString());
                    strength += currentStrength;
                }

                else if (char.IsLetterOrDigit(symbol) && strength > 0)
                {
                    text = text.Remove(i, 1);
                    strength--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}