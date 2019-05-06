using System.Linq;
using System.Collections.Generic;
using System;

namespace Append_Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<string> listFromArrays = Console.ReadLine().Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToList();


            listFromArrays.Reverse();

            List<string> result = new List<string>();

            for (int i = 0; i < listFromArrays.Count; i++)
            {
                result.AddRange(listFromArrays[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList());
            }



            Console.WriteLine(string.Join(" ", result));

        }
    }
}