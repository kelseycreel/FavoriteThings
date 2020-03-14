using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Foods
{
    class Food : FoodBase
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is ready to eat for {FoodCategory}");
        }

    }
}
