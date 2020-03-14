using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Composition.Foods
{
    abstract class FoodBase
    {
        public string Name { get; set; }
        public bool IsMeal { get; set; }
        public FoodCategory FoodCategory { get; set; }

        public abstract void Eat();

        public virtual void Leftovers()
        {
            Console.WriteLine($"There is some {Name} in the fridge.");
        }
    }
}
