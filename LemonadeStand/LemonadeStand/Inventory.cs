using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        private List<Lemon> lemons; 
        private List<Sugar> sugar;
        private List<Ice> ice;
        private List<Cup> cups;

        public int Lemons { get { return lemons.Count; } }
        public int Sugar { get { return sugar.Count; } }
        public int Ice { get { return ice.Count; } }
        public int Cups { get { return cups.Count; } }

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
                lemons.Add(new Lemon());
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
                sugar.Add(new Sugar());
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
                ice.Add(new Ice());
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
                cups.Add(new Cup());
            }
        }

        
    }
}
