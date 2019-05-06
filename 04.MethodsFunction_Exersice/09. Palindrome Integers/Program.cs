using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
                     

            while (command!="END")
            {
                IsItPalidrome(command);
                command = Console.ReadLine();
            }
        }

        private static bool IsItPalidrome(string command)
        {
            char[] reverseArray = command.ToCharArray();
            Array.Reverse(reverseArray);
            string reverseString = string.Join("", reverseArray);

            if (command==reverseString)
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
    }
}
