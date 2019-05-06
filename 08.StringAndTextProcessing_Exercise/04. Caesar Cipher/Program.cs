using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encrypText = new StringBuilder();

            for (int index = 0; index < text.Length; index++)
            {
                int oldChar = text[index]+3;
                char newChar = (char)oldChar;
                encrypText.Append(newChar);
            }
            Console.WriteLine(encrypText);
        }
    }
}
