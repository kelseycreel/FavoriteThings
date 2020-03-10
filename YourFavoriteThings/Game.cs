using System;
using System.Collections.Generic;
using System.Text;

namespace YourFavoriteThings.Game
{
    class Game
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Winner { get; set; }
        private int _TotalWins;

        public Game(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Classify()
        {
            Console.WriteLine($"{Name} is a {Type} game!");
        }

        public void Win(int wins)
        {
            if (Winner)
            {
                _TotalWins += wins;
                Console.WriteLine($"You just won {Name}!!! You now have {_TotalWins}");
            }
        }

    }
}
