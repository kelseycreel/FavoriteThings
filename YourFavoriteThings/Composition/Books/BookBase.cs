using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Books
{
    abstract class BookBase
    {
        public string Title { get; set; }
        public bool IsSeries { get; set; }
        public BookType BookType { get; set; }

        public abstract void Read();

        public virtual void Stats()
        {
            Console.WriteLine($"{Title} is a {BookType}.");
        }
    }
}
