using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split(" : ").ToArray();

            var courses = new Dictionary<string, List<string>>();

            while (command[0] != "end")
            {

                string courseName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
                command = Console.ReadLine().Split(" : ").ToArray();
            }

            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var student in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
           
        }
    }
}