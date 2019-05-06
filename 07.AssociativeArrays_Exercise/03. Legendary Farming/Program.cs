using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {           
            var farming = Console.ReadLine().Split(' ').ToList();
            

            var legendaryItem = new SortedDictionary<string, int>();
            legendaryItem.Add("shards", 0);
            legendaryItem.Add("fragments", 0);
            legendaryItem.Add("motes", 0);
            var junkItem = new SortedDictionary<string, int>();
            bool hasWinner = true;
            
            while (hasWinner)
            {
                for (int index = 0; index < farming.Count; index+=2)
                {
                    //0   1   2    3   4    5
                    //3 Motes 5 stones 5 Shards
                    //6 leathers 255 fragments 7 Shards                            
                    int quantityOfMaterial = int.Parse(farming[index]);
                    string material = farming[index + 1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!legendaryItem.ContainsKey(material))
                        {
                            legendaryItem.Add(material, quantityOfMaterial);
                        }
                        else
                        {
                            legendaryItem[material] += quantityOfMaterial;
                        }
                        if (legendaryItem[material] >= 250)
                        {
                            hasWinner = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItem.ContainsKey(material))
                        {
                            junkItem.Add(material, quantityOfMaterial);
                        }
                        else
                        {
                            junkItem[material] += quantityOfMaterial;
                        }
                    }
                }
                if (hasWinner)
                {
                    farming = Console.ReadLine().Split(' ').ToList();
                }
                
            }
            if (legendaryItem.Keys.Contains("shards") && legendaryItem["shards"] >= 250)
            {
                legendaryItem["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (legendaryItem.Keys.Contains("fragments") && legendaryItem["fragments"] >= 250)
            {
                legendaryItem["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");

            }
            else if (legendaryItem.Keys.Contains("motes") && legendaryItem["motes"] >= 250)
            {
                legendaryItem["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");

            }
            var legendaryItemOrdered = legendaryItem.OrderByDescending(x => x.Value).ToList();
            foreach (var material in legendaryItemOrdered)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junkItem)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
