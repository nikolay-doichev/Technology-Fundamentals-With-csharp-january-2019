using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Studnets> studentsList = new List<Studnets>();

            for (int index = 0; index < countOfStudents; index++)
            {
                string[] studentsInfo = Console.ReadLine()
                    .Split(' ');

                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                double grade =Math.Round(double.Parse(studentsInfo[2]),2);
                

                var students = new Studnets(firstName, lastName, grade);

                studentsList.Add(students);
            }
            studentsList = studentsList.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, studentsList));
        }
    }
   public class Studnets
    {
        public Studnets (string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
