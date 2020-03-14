using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Movies
{
    class UnownedMovie : MovieBase
    {
        public override void Watch()
        {
            Console.WriteLine($"Oh no... you don't own {Name}... we can't watch it!");
        }
    }
}
