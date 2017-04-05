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

        public string Name { get { return name; } set { name = value; } }

        public Player(string Name)
        {
            name = Name;
            store = new Store();
        }
    }
}
