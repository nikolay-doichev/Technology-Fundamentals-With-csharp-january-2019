using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyAndEmployee = Console.ReadLine().Split(" -> ").ToList();
            var companyAndEmployeeList = new Dictionary<string, List<string>>();

            while (companyAndEmployee[0]!="End")
            {
                string company = companyAndEmployee[0];
                string employee = companyAndEmployee[1];

                if (!companyAndEmployeeList.ContainsKey(company))
                {
                    companyAndEmployeeList.Add(company,new List<string>());
                    companyAndEmployeeList[company].Add(employee);
                }
                else
                {
                    if (!companyAndEmployeeList[company].Contains(employee))
                    {
                        companyAndEmployeeList[company].Add(employee);
                    }
                }
                companyAndEmployee = Console.ReadLine().Split(" -> ").ToList();
            }

            foreach (var item in companyAndEmployeeList.OrderBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
