using System;
using System.Collections.Generic;
using System.Text;

namespace Movies
{
    public class Movie
    {
        private string MovieTitle;
        private string MovieCategory;

        public Movie(string movieTitle, string movieCategory)
        {
            MovieTitle1 = movieTitle;
            MovieCategory1 = movieCategory;
        }

        public string MovieTitle1 { get => MovieTitle; set => MovieTitle = value; }
        public string MovieCategory1 { get => MovieCategory; set => MovieCategory = value; }

        public override string ToString()
        {
            return $"{MovieTitle1}";
        }
    }
}

