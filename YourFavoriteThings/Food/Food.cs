using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Food
{
    class Food
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }

        public Food(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void Eat()
        {
            if (Age > 1)
            {
                Console.WriteLine($"Oops! Looks like your {Name} is a bit old...");
            } else
                Console.WriteLine($"{Name} is now {Location}");
        }

    }
}
