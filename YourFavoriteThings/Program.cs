using System;
using YourFavoriteThings.Food;
using YourFavoriteThings.Pet;
using YourFavoriteThings.Game;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var pickle = new Food.Food("pickle", "in my belly");
            pickle.Eat();

            var popcorn = new Food.Food("popcorn", "in my kitchen")
            {
                Age = 2
            };
            popcorn.Eat();

            var stormy = new Pet.Pet("Stormy", "woof")
            {
                Animal = "dog",
                IsFriendly = true
            };
            stormy.Greet();
            stormy.Fetch();

            var blue = new Pet.Pet("Blue", "bark bark");
            blue.Greet();
            blue.Fetch();

            var monopoly = new Game.Game("Monopoly", "board");
            monopoly.Classify();
            monopoly.Win(2);

            Console.ReadKey();
        }
    }
}
