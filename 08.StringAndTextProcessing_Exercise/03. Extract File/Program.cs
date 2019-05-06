using System;
using System.Linq;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Console.ReadLine().Split('\\').ToArray();
            var fileForSubstring = filePath[filePath.Length - 1].Split('.');
            string fileName = fileForSubstring[0];
            string fileExtension = fileForSubstring[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
            
        }
    }
}
