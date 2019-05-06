using System;

namespace _09.StringAndTextProcessing_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesValidator = Console.ReadLine().Split(", ");
            //•	Has length between 3 and 16 characters
            //•	Contains only letters, numbers, hyphens and underscores
            //•	Has no redundant symbols before, after or in between
            bool requaredSymboll = false;

            for (int index = 0; index < namesValidator.Length; index++)
            {
                //sh, too_long_username, !lleg@l ch@rs, jeffbutt
                if (namesValidator[index].Length>=3 && namesValidator[index].Length<=16)
                {
                    string currentWord = namesValidator[index];
                    
                    for (int index2 = 0; index2 < currentWord.Length; index2++)
                    {
                        if (char.IsLetterOrDigit(currentWord[index2]) ||
                                                 currentWord[index2]=='-'||
                                                 currentWord[index2] == '_')
                        {
                            requaredSymboll = true;
                        }
                        else
                        {
                            requaredSymboll = false;
                            break;
                        }
                    }
                    if (requaredSymboll)
                    {
                        Console.WriteLine(currentWord);
                    }
                }
            }
        }
    }
}
