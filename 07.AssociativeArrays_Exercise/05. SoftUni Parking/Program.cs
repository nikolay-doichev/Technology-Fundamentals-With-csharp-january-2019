using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Parking
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var registerList = new Dictionary<string, string>();

            for (int index = 0; index < numberOfCommands; index++)
            {
                var commandLine = Console.ReadLine().Split(' ').ToArray();
                string command = commandLine[0];
                string username = commandLine[1];


                if (command == "register")
                {
                    string licensePlateNumber = commandLine[2];
                    if (!registerList.ContainsKey(username))
                    {
                        registerList[username] = licensePlateNumber;
                        Console.WriteLine("{0} registered {1} successfully", username, licensePlateNumber);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", licensePlateNumber);
                    }
                }
                else
                {
                    if (registerList.ContainsKey(username))
                    {
                        registerList.Remove(username);
                        Console.WriteLine("{0} unregistered successfully", username);
                    }
                    else
                    {
                        Console.WriteLine("ERROR: user {0} not found", username);
                    }
                }
            }

            foreach (var item in registerList)
            {
                Console.WriteLine("{0} => {1}", item.Key, item.Value);
            }
            //Console.Write("Press any key to continue . . . ");
            //Console.ReadKey(true);
        }
    }
}