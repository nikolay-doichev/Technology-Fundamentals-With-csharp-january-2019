using System;
using System.Text.RegularExpressions;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<prize>[0-9]+\.?[0-9]+)\$";

            string input = string.Empty;
            double totalIncome = 0.0;

            while ((input=Console.ReadLine())!= "end of shift")
            {
                Regex order = new Regex(pattern);

                if (order.IsMatch(input))
                {
                    string customerName = order.Match(input).Groups["customer"].Value;
                    string productName = order.Match(input).Groups["product"].Value;
                    int count = int.Parse(order.Match(input).Groups["count"].Value);
                    double prize = double.Parse(order.Match(input).Groups["prize"].Value);

                    double totalPrize = prize * count;

                    totalIncome += totalPrize;

                    Console.WriteLine($"{customerName}: {productName} - {totalPrize:F2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
