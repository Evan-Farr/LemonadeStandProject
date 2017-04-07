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

        public bool RemoveLemons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if (LemonsList.Count != 0)
                {
                    LemonsList.RemoveAt(0);
                    return true;
                }
            }
            return false;
        }
        public void AddLemon(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
               lemonsList.Add(new Lemon());
            }
        }

        public bool RemoveSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if(SugarList.Count != 0)
                {
                    SugarList.RemoveAt(0);
                    return true;
                }
            }
            return false;
        }
        public void AddSugar(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                SugarList.Add(new Sugar());
            }
        }

        public bool RemoveIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if(IceList.Count != 0)
                {
                    IceList.RemoveAt(0);
                    return true;
                }
            }
            return false;
        }
        public void AddIce(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                IceList.Add(new Ice());
            }
        }

        public bool RemoveCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                if(CupsList.Count != 0)
                {
                    CupsList.RemoveAt(0);
                    return true;
                }
            }
            return false;
        }
        public void AddCups(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                CupsList.Add(new Cup());
            }
        }
    }
}
