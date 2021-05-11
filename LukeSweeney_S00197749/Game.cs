using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeSweeney_S00197749
{
    class Game
    {
        public string Name { get; set; }
        public double CriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public Game(string name, string platform, double score, decimal price, string image, string description)
        {
            Name = name;
            CriticScore = score;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = image;
        }
    }
}
