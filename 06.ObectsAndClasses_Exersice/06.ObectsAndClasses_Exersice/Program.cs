using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ObectsAndClasses_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());
            
            for (int index = 0; index < rotation; index++)
            {
                Messages messages1 = new Messages();
                Console.WriteLine(messages1);
            }
        }
    }
    class Messages
    {
        public string Phrases ()
        {
            string[] Phrases = { "Excellent product.",
                                 "Such a great product.",
                                 "I always use that product.",
                                 "Best product of its category.",
                                 "Exceptional product.",
                                 "I can’t live without this product." };
            Random random = new Random();
            int rnd = random.Next(0,Phrases.Length);
            return Phrases[rnd];
        }
        public string Events ()
        {
            string[] Phrases = { "Now I feel good.",
                                 "I have succeeded with this product.",
                                 "Makes miracles. I am happy of the results!",
                                 "I cannot believe but now I feel awesome.",
                                 "Try it yourself, I am very satisfied.",
                                 "I feel great!" };
            Random random = new Random();
            int rnd = random.Next(0, Phrases.Length);
            return Phrases[rnd];
        }
        public string Authors()
        {
            string[] Phrases = { "Diana",
                                 "Petya",
                                 "Stella",
                                 "Elena",
                                 "Katya",
                                 "Iva",
                                 "Annie",
                                 "Eva" };
            Random random = new Random();
            int rnd = random.Next(0, Phrases.Length);
            return Phrases[rnd];
        }
        public string Cities()
        {
            string[] Phrases = { "Burgas",
                                 "Sofia",
                                 "Plovdiv",
                                 "Varna",
                                 "Ruse" };
            Random random = new Random();
            int rnd = random.Next(0, Phrases.Length);
            return Phrases[rnd];
        }
    }
}
