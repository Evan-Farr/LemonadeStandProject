using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        private List<Lemon> lemonsList; 
        private List<Sugar> sugarList;
        private List<Ice> iceList;
        private List<Cup> cupsList;


        public int Lemons { get { return lemonsList.Count; } }
        public int Sugar { get { return sugarList.Count; } }
        public int Ice { get { return iceList.Count; } }
        public int Cups { get { return cupsList.Count; } }

        public Inventory()
        {
            lemonsList = new List<Lemon>();
            sugarList = new List<Sugar>();
            iceList = new List<Ice>();
            cupsList = new List<Cup>();
        }

        public void RemoveLemons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                lemonsList.RemoveAt(0);
            }
        }
        public void AddLemon(int amount, Player player1, Lemon lemon)
        {
            for (int i = 0; i < amount; i++)
            {
                lemonsList.Add(new Lemon());
            }
            player1.Store.Money -= (amount * lemon.Price);
        }

        public void RemoveSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                sugarList.RemoveAt(0);
            }
        }
        public void AddSugar(int amount, Player player1, Sugar sugar)
        {
            for (int i = 0; i < amount; i++)
            {
                sugarList.Add(new Sugar());
            }
            player1.Store.Money -= (amount * sugar.Price);
        }

        public void RemoveIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                iceList.RemoveAt(0);
            }
        }
        public void AddIce(int amount, Player player1, Ice ice)
        {
            for (int i = 0; i < amount; i++)
            {
                iceList.Add(new Ice());
            }
            player1.Store.Money -= (amount * ice.Price);
        }

        public void RemoveCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cupsList.RemoveAt(0);
            }
        }
        public void AddCups(int amount, Player player1, Cup cup)
        {
            for (int i = 0; i < amount; i++)
            {
                cupsList.Add(new Cup());
            }
            player1.Store.Money -= (amount * cup.Price);
        }
    }
}
