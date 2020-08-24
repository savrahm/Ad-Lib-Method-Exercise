using System;

namespace Method_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! To start an ad lib, type in a noun.");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Nice! Choose one and type it in: who, what, when, where, or why?");
            string whoWhat = Console.ReadLine();

            Console.WriteLine("Now type in a verb.");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Okay, another noun!");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Great! Another noun.");
            string noun3 = Console.ReadLine();

            Console.WriteLine("Lol another noun your life is over now it's only nouns");
            string noun4 = Console.ReadLine();

            Console.WriteLine("Just playing, give me another verb. Last one.");
            string verb2 = Console.ReadLine();

            Console.WriteLine("Got it! Here's the ad lib you made:");
            Console.WriteLine();
            Console.WriteLine($"Twinkle twinkle little {noun1}");
            Console.WriteLine($"How I wonder {whoWhat} you {verb1}");
            Console.WriteLine($"Up above the {noun2} so high");
            Console.WriteLine($"Like a {noun3} in the {noun4}");
            Console.WriteLine($"{verb2} {verb2} little {noun1}");
            Console.WriteLine($"How I wonder {whoWhat} you {verb1}.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wow, that's really beautiful.");
             
            
        }
    }
}
