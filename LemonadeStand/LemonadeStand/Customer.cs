using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        private double maxWillingToPay;
        private int lemonPreference;
        private int sugarPreference;
        private int icePreference;
        private int chanceOfBuying;
        private int cupsBought;
        private Day currentDay;
        private Inventory inventory;
        private Random random;

        public double MaxWillingToPay { get { return maxWillingToPay; } }
        public int LemonPreference { get { return lemonPreference; } }
        public int ChanceOfBuying { get { return chanceOfBuying; } }
        public int CupsBought { get { return cupsBought; } set { CupsBought = value; } }
        public Inventory Inventory { get { return inventory; } set { inventory = value; } }

        public Customer(Day CurrentDay, Random Random)
        {
            random = Random;
            currentDay = CurrentDay;
            maxWillingToPay = SetMaxWillingToPay();
            chanceOfBuying = DetermineChanceOfBuying();
            lemonPreference = SetLemonPreference();
            sugarPreference = SetSugarPreference();
            icePreference = SetIcePreference();
            cupsBought = 0;
        }

        private double SetMaxWillingToPay()
        {
            maxWillingToPay = random.NextDouble() * (6 - 1) + 1;
            maxWillingToPay = Math.Round(maxWillingToPay, 2);
            return maxWillingToPay;
        }

        private void SetTastePreference()
        {
            lemonPreference = random.Next(1, 5);
            sugarPreference = random.Next(1, 6);
            icePreference = random.Next(1, 10);
        }

        private int DetermineChanceOfBuying()
        {
            int amount = random.Next(11);
            return chanceOfBuying;
        }

        public void BuyLemonade()
        {
            if(maxWillingToPay < currentDay.LemonadePrice)
            {
                cupsBought = 0;
            }else if(maxWillingToPay >= currentDay.LemonadePrice)
            {
                if (lemonPreference == currentDay.Recipe.LemonAmount && sugarPreference == currentDay.Recipe.SugarAmount && icePreference == currentDay.Recipe.IceAmount)
                {
                    cupsBought = 3;
                    currentDay.Sales += (3 * currentDay.LemonadePrice);
                    currentDay.Customers.Add(this);
                    Inventory.RemoveLemons(3 * currentDay.Recipe.LemonAmount);
                    Inventory.RemoveSugar(3 * currentDay.Recipe.SugarAmount);
                    Inventory.RemoveIce(3 * currentDay.Recipe.IceAmount);
                    Inventory.RemoveCups(3);
                }else 
                {
                    int amount = random.Next(2);
                    if (amount == 0)
                    {
                        cupsBought = 0;
                    }
                    else if (amount == 1)
                    {
                        cupsBought = 1;
                        currentDay.Sales += currentDay.LemonadePrice;
                        currentDay.Customers.Add(this);
                        Inventory.RemoveLemons(currentDay.Recipe.LemonAmount);
                        Inventory.RemoveSugar(currentDay.Recipe.SugarAmount);
                        Inventory.RemoveIce(currentDay.Recipe.IceAmount);
                        Inventory.RemoveCups(1);
                    }
                }
            }
        }
    }
}
