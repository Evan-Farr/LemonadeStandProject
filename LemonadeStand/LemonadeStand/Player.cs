using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        private string name;
        public Store store;
        private double currentScore;
        private double highScore;

        public Player(string Name)
        {
            name = Name;
            store = new Store();
        }

        public string Name { get { return name; } set { name = value; } }

        public double CurrentScore { get { return currentScore; } set { currentScore = value; } }

        public double HighScore { get { return highScore; } set { highScore = value; } }
    }
}
