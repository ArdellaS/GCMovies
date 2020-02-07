
using System;
using System.Collections.Generic;
using System.Text;


class Movies
{
    public string MovieTitle { get; set; }
    public string MovieCategory { get; set; }

    
    public Movies(string movieTitle, string movieCategory)
    {
        MovieTitle = movieTitle;
        MovieCategory = movieCategory;

    }
    
    public override string ToString()
    {
        return $"{MovieTitle}";
    }
    
}
