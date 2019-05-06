using System;

namespace _01.Advertisement_Message_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.",
                                 "Such a great product.",
                                 "I always use that product.",
                                 "Best product of its category.",
                                 "Exceptional product.",
                                 "I can’t live without this product." };
            string[] Events = { "Now I feel good.",
                                 "I have succeeded with this product.",
                                 "Makes miracles. I am happy of the results!",
                                 "I cannot believe but now I feel awesome.",
                                 "Try it yourself, I am very satisfied.",
                                 "I feel great!" };

            string[] Authors = { "Diana",
                                 "Petya",
                                 "Stella",
                                 "Elena",
                                 "Katya",
                                 "Iva",
                                 "Annie",
                                 "Eva" };

            string[] Cities = { "Burgas",
                                 "Sofia",
                                 "Plovdiv",
                                 "Varna",
                                 "Ruse" };

            for (int index = 0; index < rotation; index++)
            {
                Random random = new Random();
                int rnd = random.Next(0, Phrases.Length);
                string phrase = Phrases[rnd];

                int rnd2 = random.Next(0, Events.Length);
                string events = Phrases[rnd2];

                int rnd3 = random.Next(0, Authors.Length);
                string author = Phrases[rnd3];

                int rnd4 = random.Next(0, Cities.Length);
                string city = Phrases[rnd4];

                Console.WriteLine($"{phrase} {events} {author} – {city}");
            }
        }
    }
}
