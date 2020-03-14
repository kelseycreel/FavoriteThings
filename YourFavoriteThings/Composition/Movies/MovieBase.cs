using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Movies
{
    abstract class MovieBase
    {
        public string Name { get; set; }
        public MovieType MovieType { get; set; }
        public bool Own { get; set; }
        public string Rating { get; set; }


        public abstract void Watch();

    }
}
