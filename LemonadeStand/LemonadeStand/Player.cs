using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Store store;

        public Player(string Name)
        {
            name = Name;
            store = new Store();
        }
    }
}
