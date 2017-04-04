using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string name;
        public Store store;
        private double currentScore;
        private double highScore;

        public Player(string Name)
        {
            name = Name;
            store = new Store();
        }
    }
}
