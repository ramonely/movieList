using System;
using System.Collections.Generic;
using System.Text;

namespace movieList
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }
    }
}