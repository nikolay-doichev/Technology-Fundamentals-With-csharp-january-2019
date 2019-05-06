using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            var studentAverageGrade = new Dictionary<string, List<double>>();

            for (int index = 0; index < numberOfRows; index++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentAverageGrade.ContainsKey(studentName))
                {
                    studentAverageGrade[studentName] = new List<double>();
                    studentAverageGrade[studentName].Add(grade);
                }
                else
                {
                    studentAverageGrade[studentName].Add(grade);
                }
            }
            var averageGrade = new Dictionary<string, double>();
            foreach (var item in studentAverageGrade)
            {
                double average = item.Value.Average();
                if (average<4.5)
                {
                    continue;
                }
                averageGrade.Add(item.Key, average);
            }

            foreach (var student in averageGrade.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                
            }
        }
    }
}
