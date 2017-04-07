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

        public List<Lemon> LemonsList { get { return lemonsList; } set { lemonsList = value; } }
        public List<Sugar> SugarList { get { return sugarList; } set { sugarList = value; } }
        public List<Ice> IceList { get { return iceList; } set { iceList = value; } }
        public List<Cup> CupsList { get { return cupsList; } set { cupsList = value; } }
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
                LemonsList.RemoveAt(0);
            }
        }
        public void AddLemon(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
               LemonsList.Add(new Lemon());
            }
        }

        public void RemoveSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if(SugarList.Count != 0)
                {
                    SugarList.RemoveAt(0);
                }else
                {
                    UserInterface.AlertEmptyInventoryItem(player1, currentDay);
                }
                
            }
        }
        public void AddSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                SugarList.Add(new Sugar());
            }
            player1.Store.Money -= (amount * sugar.Price);
        }

        public void RemoveIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                IceList.RemoveAt(0);
            }
        }
        public void AddIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                IceList.Add(new Ice());
            }
            player1.Store.Money -= (amount * ice.Price);
        }

        public void RemoveCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                CupsList.RemoveAt(0);
            }
        }
        public void AddCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                CupsList.Add(new Cup());
            }
            player1.Store.Money -= (amount * cup.Price);
        }
    }
}
