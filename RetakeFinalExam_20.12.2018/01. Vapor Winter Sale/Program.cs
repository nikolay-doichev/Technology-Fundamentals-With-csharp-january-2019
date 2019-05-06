using System;
using System.Collections.Generic;
using System.Linq;

namespace RetakeFinalExam_20._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> gamesAndPrices = new Dictionary<string, decimal>();
            Dictionary<string, string> gamesAndDlc = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(", ");

            for (int index = 0; index < input.Length; index++)
            {
                //WitHer 3:Blood and Beer
                if (input[index].Contains(":"))
                {
                    string[] tokensDlc = input[index].Split(":");
                    //WitHer 3
                    //Blood and Beer

                    string gameName = tokensDlc[0];
                    string dlc = tokensDlc[1];

                    if (gamesAndPrices.ContainsKey(gameName))
                    {
                        gamesAndDlc.Add(gameName, dlc);

                        decimal increasedPrice = gamesAndPrices[gameName] + gamesAndPrices[gameName] * 0.20m;
                        gamesAndPrices[gameName] = increasedPrice;
                    }
                }
                else
                {
                    //WitHer 3-50
                    string[] tokensWithoutDlc = input[index].Split("-");
                    //WitHer 3
                    //50
                    string gameName = tokensWithoutDlc[0];
                    decimal gamePrice = decimal.Parse(tokensWithoutDlc[1]);

                    gamesAndPrices.Add(gameName, gamePrice);
                }
            }

            var gamesAndLowerPriceWithouttDlc = new Dictionary<string, decimal>();
            var GamesAndLowerPriceWithDlc = new Dictionary<string, decimal>();

            foreach (var game in gamesAndPrices)
            {
                string gameName = game.Key;
                decimal price = game.Value;

                if (!gamesAndDlc.ContainsKey(gameName))
                {
                    decimal lowerdPrice = price - (price * 0.2m);
                    gamesAndLowerPriceWithouttDlc.Add(gameName, lowerdPrice);
                }
                else
                {
                    decimal lowerdPrice = price - (price * 0.5m);
                    GamesAndLowerPriceWithDlc.Add(gameName, lowerdPrice);
                }
            }
            foreach (var kvp in GamesAndLowerPriceWithDlc.OrderBy(x=>x.Value))
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                Console.WriteLine($"{name} - {gamesAndDlc[kvp.Key]} - {price:f2}");
            }
            foreach (var kvp in gamesAndLowerPriceWithouttDlc.OrderByDescending(x=>x.Value))
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                Console.WriteLine($"{name} - {price:f2}");
            }
        }
    }
}
