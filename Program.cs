using System;
using System.Collections.Generic;
using System.Collections;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Got a selection of good movies on sale stranga'.");
            do
            {

                List<Movies> flicks = new List<Movies>();
                flicks.Add(new Movies("Silent Hill", "horror"));
                flicks.Add(new Movies("Hellraiser", "horror"));
                flicks.Add(new Movies("All About the Benjamins", "comedy"));
                flicks.Add(new Movies("Money Talks", "comedy"));
                flicks.Add(new Movies("True Lies", "action"));
                flicks.Add(new Movies("The Mummy", "action"));
                flicks.Add(new Movies("Homeward Boud", "family"));
                flicks.Add(new Movies("Warriors of Virtue", "family"));
                flicks.Add(new Movies("Cats Don't Dance", "animated"));
                flicks.Add(new Movies("The Incredibles", "animated"));

                string genre = GetString("What genre might interest ya?").ToLower();

                List<Movies> films = new List<Movies>();

                var value = flicks.Find(genre => genre.Equals(genre));

                Console.WriteLine(value);

                foreach (var film in films)
                {
                    Console.WriteLine(film);
                }

            } while (Again());
            Console.WriteLine("Hehehe... Thank you.");
        }

        public static string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        static bool Again()
        {
            char c;

            do
            {
                Console.WriteLine("Would you like to continue? y/n");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
            } while (c != 'y' && c != 'Y');

            return true;

        }

    }
}
