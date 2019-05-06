using System;
using System.Collections.Generic;

namespace _02._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = Console.ReadLine().Split('&');

            List<string> validKeys = new List<string>();

            foreach (var key in keys)
            {
                if (key.Length == 16 || key.Length == 25)
                {
                    bool isValid = true;

                    foreach (var symbol in key)
                    {
                        if (!char.IsLetterOrDigit(symbol))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validKeys.Add(key);
                    }
                }
            }

            for (int index = 0; index < validKeys.Count; index++)
            {
                if (validKeys[index].Length == 16)
                {
                    validKeys[index] = validKeys[index].Insert(4, "-");
                    validKeys[index] = validKeys[index].Insert(9, "-");
                    validKeys[index] = validKeys[index].Insert(14, "-");
                }
                else if (validKeys[index].Length == 25)
                {
                    validKeys[index] = validKeys[index].Insert(5, "-");
                    validKeys[index] = validKeys[index].Insert(11, "-");
                    validKeys[index] = validKeys[index].Insert(17, "-");
                    validKeys[index] = validKeys[index].Insert(23, "-");
                }
            }
            for (int i = 0; i < validKeys.Count; i++)
            {
                for (int j = 0; j < validKeys[i].Length; j++)
                {
                    if (char.IsDigit(validKeys[i][j]))
                    {
                        int currentDigit = 9 - int.Parse(validKeys[i][j].ToString());
                        validKeys[i] = validKeys[i].Remove(j, 1);
                        validKeys[i] = validKeys[i].Insert(j, currentDigit.ToString());
                    }
                }
                validKeys[i] = validKeys[i].ToUpper();
            }
            if (validKeys.Count>0)
            {
                Console.WriteLine(string.Join(", ",validKeys));
            }
        }
    }
}
