using System;

namespace lectureArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                     "Monday",
                     "Tuesday",
                     "Wednesday",
                     "Thursday",
                     "Friday",
                     "Saturday",
                     "Sunday"
                            };
            int index = int.Parse(Console.ReadLine());
            if (index > 7 || index < 1)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(days[index - 1]);
        }
    }
}
