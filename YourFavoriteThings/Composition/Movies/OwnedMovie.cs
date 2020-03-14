using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Movies
{
    class OwnedMovie : MovieBase
    {
        public override void Watch()
        {
            Console.WriteLine($"Let's watch {Name}!!! It's an {MovieType} movie.");
        }
    }
}
