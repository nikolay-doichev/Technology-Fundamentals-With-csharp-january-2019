using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAllPeople = int.Parse(Console.ReadLine());
            int maxPeopleOfOneCourse = int.Parse(Console.ReadLine());


            Console.WriteLine((int)Math.Ceiling((double)numberOfAllPeople / maxPeopleOfOneCourse));
        }
    }
}
