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
        private Store store;

        public string Name { get { return name; } set { name = value; } }
        public Store Store { get { return store; } }

        public Player(string Name, Random random)
        {
            name = Name;
            store = new Store(random);
        }
    }
}
