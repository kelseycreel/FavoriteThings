using System;
using System.Collections.Generic;
using YourFavoriteThings.Composition.Books;
using YourFavoriteThings.Composition.Foods;
using YourFavoriteThings.Composition.Movies;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var ReadyPlayerOne = new ReadBook()
            {
                Title = "Ready Player One",
                IsSeries = false,
                BookType = BookType.paperback
            };

            ReadyPlayerOne.Read();
            ReadyPlayerOne.Stats();

            var ThousandLeagues = new UnreadBook()
            {
                Title = "Thousand Leagues under the Sea",
                IsSeries = false,
                BookType = BookType.hardback
            };

            ThousandLeagues.Read();
            ThousandLeagues.Stats();

            var eggs = new Food()
            {
                Name = "scrambled eggs",
                IsMeal = true,
                FoodCategory = FoodCategory.breakfast
            };

            eggs.Eat();
            eggs.Leftovers();

            var Indiana = new OwnedMovie()
            {
                Name = "Indiana Jones and the Holy Grail",
                MovieType = MovieType.action,
                Rating = "PG-13"
            };

            Indiana.Watch();

            Console.ReadKey();
        }
    }
}
