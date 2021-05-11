using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LukeSweeney_S00197749
{
    public class Game
    {
        //properties
        [Key]
        public string Name { get; set; }
        public double CriticScore { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        //contructors
        public Game() { }
        public Game(string name, string platform, double score, decimal price, string image, string description)
        {
            Name = name;
            CriticScore = score;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = image;
        }

        //methods
        public void DecreasePrice(double amount)
        {
            Price -= (decimal)amount;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class GameData: DbContext
    {
        public GameData() : base("GameInformation") { }
        public DbSet<Game> Games { get; set; }
    }
}
