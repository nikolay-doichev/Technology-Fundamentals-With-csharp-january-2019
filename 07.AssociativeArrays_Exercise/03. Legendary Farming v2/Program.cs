using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            dict["fragments"] = 0;
            dict["shards"] = 0;
            dict["motes"] = 0;
            var junkElements = new Dictionary<string, int>();

            while (true)
            {
                bool haveWinner = false;
                var tokens = Console.ReadLine().ToLower().Split(' ').ToArray();
                for (int i = 0; i < tokens.Length; i+=2)
                {
                    string type = tokens[i + 1];
                    int quantity = int.Parse(tokens[i]);

                    if (dict.ContainsKey(type))
                    {
                        dict[type] += quantity;
                        if (dict[type]>=250)
                        {
                            haveWinner = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkElements.ContainsKey(type))
                        {
                            junkElements[type] += quantity;
                        }
                        else
                        {
                            junkElements[type]=quantity;
                        }
                    }

                }
                if (haveWinner)
                {
                    break;
                }
            }


        }
    }
}
