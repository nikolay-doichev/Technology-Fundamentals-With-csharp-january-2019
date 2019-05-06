using System;
using System.Collections.Generic;
using System.Linq;

namespace _06Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                var input = command.Split(" : ").ToArray();
                string courseName = input[0];
                string studentName = input[1];

                if (!students.ContainsKey(courseName))
                {
                    students[courseName] = new List<string>();
                    students[courseName].Add(studentName);

                }
                else if (!students[courseName].Contains(studentName))
                {
                    students[courseName].Add(studentName);

                }
            }

            foreach (var kvp in students.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var student in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}