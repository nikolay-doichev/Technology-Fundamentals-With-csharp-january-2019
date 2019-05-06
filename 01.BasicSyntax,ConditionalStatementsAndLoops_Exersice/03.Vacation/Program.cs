using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            string typeClass = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double sumPrice = 0;

            if (typeClass == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    sumPrice = persons * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    sumPrice = persons * 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    sumPrice = persons * 10.46;
                }
                if (persons >= 30)
                {
                    sumPrice = sumPrice * 0.85;
                }
            }
            else if (typeClass == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    sumPrice = persons * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    sumPrice = persons * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    sumPrice = persons * 16.00;
                }
                if (persons >= 100)
                {
                    double price = 0;
                    price = sumPrice / persons;
                    persons -= 10;
                    sumPrice = price * persons;
                }
            }
            else if (typeClass == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    sumPrice = persons * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    sumPrice = persons * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    sumPrice = persons * 22.50;
                }
                if (persons >= 10 & persons <= 20)
                {
                    sumPrice = sumPrice * 0.95;
                }

            }
            Console.WriteLine($"Total price: {sumPrice:F2}");
        }
    }
}
