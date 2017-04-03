using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Lemon> lemons;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Cup> cups;

        public Inventory()
        {
            lemons = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cups = new List<Cup>();
        }

        public void RemoveLemons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                lemons.RemoveAt(0);
            }
        }
        public void AddLemon(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                lemons.Add(new Lemon(.15, 1));
            }
        }

        public void RemoveSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                sugar.RemoveAt(0);
            }
        }
        public void AddSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                sugar.Add(new Sugar(.20, 1));
            }
        }

        public void RemoveIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                ice.RemoveAt(0);
            }
        }
        public void AddIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                ice.Add(new Ice(.05, 1));
            }
        }

        public void RemoveCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cups.RemoveAt(0);
            }
        }
        public void AddCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cups.Add(new Cup(.5, 1));
            }
        }

    }
}
