using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Books
{
    class ReadBook : BookBase
    {
        public override void Read()
        {
            Console.WriteLine($"Congrats! You have read {Title}");
        }
    }
}
