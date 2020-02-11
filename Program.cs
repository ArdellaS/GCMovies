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

                List<Movie> flicks = new List<Movie>();
                flicks.Add(new Movie("Silent Hill", "horror"));
                flicks.Add(new Movie("Hellraiser", "horror"));
                flicks.Add(new Movie("All About the Benjamins", "comedy"));
                flicks.Add(new Movie("Money Talks", "comedy"));
                flicks.Add(new Movie("True Lies", "action"));
                flicks.Add(new Movie("The Mummy", "action"));
                flicks.Add(new Movie("Homeward Bound", "family"));
                flicks.Add(new Movie("Warriors of Virtue", "family"));
                flicks.Add(new Movie("Cats Don't Dance", "animated"));
                flicks.Add(new Movie("The Incredibles", "animated"));

                string genre = GetString("What genre might interest ya?").ToLower();

                List<Movie> films = flicks.FindAll(movie => movie.MovieCategory1==genre);

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
