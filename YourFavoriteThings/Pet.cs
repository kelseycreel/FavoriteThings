using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Pet
{
    class Pet
    {
        public string Animal { get; set; }
        public bool IsFriendly { get; set; }
        public string Name { get; set; }
        public string Greeting { get; set; }

        public Pet(string name, string greeting)
        {
            Name = name;
            Greeting = greeting;
        }

        public void Greet()
        {
            if (!string.IsNullOrEmpty(Animal) && IsFriendly == true)
            {
                Console.WriteLine($"{Name}, the {Animal} says {Greeting}!");
            } else 
                Console.WriteLine($"{Name} says {Greeting}!");
        }

        public void Fetch()
        {
            if (IsFriendly == true)
            {
                Console.WriteLine($"{Name} is playing fetch!");
            }
            else
                Console.WriteLine($"{Name} is not friendly!");
        }

    }
}
