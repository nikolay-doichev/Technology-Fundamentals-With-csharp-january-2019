using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoFinalExam_06._04._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, List<string>>();
            var wordsForPrint = new List<string>();

            while (input != "End" && input != "List")
            {
                //programmer: an animal, which turns coffee into code | developer: a magician Pesho | Gosho

                var worldWithDefinition = input.Split(" | ");
                for (int index = 0; index < worldWithDefinition.Length; index++)
                {
                    var worldSeparetedFromDefiniton = worldWithDefinition[index].Split(": ");
                    //programmer: an animal, which turns coffee into code
                    //Gosho
                    if (worldSeparetedFromDefiniton.Length >= 2)
                    {
                        string world = worldSeparetedFromDefiniton[0];
                        string definition = worldSeparetedFromDefiniton[1];
                        if (!dictionary.ContainsKey(world))
                        {
                            dictionary[world] = new List<string>();
                            dictionary[world].Add(definition);
                        }
                        else
                        {
                            dictionary[world].Add(definition);
                        }

                    }
                    else
                    {
                        wordsForPrint.Add(worldSeparetedFromDefiniton[0]);
                    }

                }
                input = Console.ReadLine();

            }
            if (input == "List")
            {
                foreach (var world in dictionary.OrderBy(x => x.Key))
                {
                    Console.Write(world.Key + " ");
                }
            }

            if (input == "End")
            {
                for (int i = 0; i < wordsForPrint.Count; i++)
                {
                    foreach (var world in dictionary.OrderBy(x => x.Key))
                    {
                        if (world.Key == wordsForPrint[i])
                        {
                            Console.WriteLine($"{world.Key}");
                            foreach (var definition in world.Value.OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($" -{definition}");
                            }
                        }
                    }
                }
            }
        }
    }
}
