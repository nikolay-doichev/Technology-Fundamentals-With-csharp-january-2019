using System;
using System.Text;
using System.Text.RegularExpressions;


namespace _02._Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^d-z{}|#]+";
            string senteceForEncrypt = Console.ReadLine();
            var letersForSubstring = Console.ReadLine().Split(' ');
            StringBuilder encryptedText = new StringBuilder();

            Regex encrypt = new Regex(pattern);

            if (!encrypt.IsMatch(senteceForEncrypt))
            {
                //wkhfn#|rx#jhqfkr#phf#exw#|rxu#uholf#lv#khfgohg#lq#hfrwkhu#sohfhw
                for (int index = 0; index < senteceForEncrypt.Length; index++)
                {
                    int currentChar = senteceForEncrypt[index];
                    char newChar = (char)(currentChar - 3);
                    encryptedText.Append(newChar);
                    //string finalText = encryptedText.ToString().Replace(letersForSubstring[0], letersForSubstring[1]);                    
                }
                foreach (var letters in encryptedText.ToString())
                {
                    if (encryptedText.ToString().Contains(letersForSubstring[0]))
                    {
                        encryptedText = encryptedText.Replace(letersForSubstring[0], letersForSubstring[1]);
                    }
                }
                Console.WriteLine(encryptedText);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }            
        }
    }
}
