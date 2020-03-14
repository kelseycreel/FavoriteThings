using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Books
{
    class UnreadBook : BookBase
    {
        public override void Read()
        {
            Console.WriteLine($"Slacker!! You MUST read {Title}");
        }
    }
}
