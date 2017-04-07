using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        private Inventory inventory;
        private double money;
        private double dailyProfitLoss;
        private double runningProfitLoss;
        private int daysOpen;
        private Random random;

        public Inventory Inventory { get { return inventory; } }
        public double Money { get { return money; } set { money = value; } }
        public double DailyProfitLoss { get { return dailyProfitLoss; } set { dailyProfitLoss = value; } }
        public double RunningProfitLoss { get { return runningProfitLoss; } set { runningProfitLoss = value; } }
        public int DaysOpen { get { return daysOpen; } set { daysOpen = value; } }

        public Store(Random Random)
        {
            random = Random;
            inventory = new Inventory();
            money = 200;
            daysOpen = 1;
        }

        public void SellLemonade(Lemonade lemonade, Day currentDay)
        {
            for(int i = 0; i < currentDay.PotentialCustomers.Count; i++)
            {
                if (currentDay.PotentialCustomers[i].MaxWillingToPay < lemonade.PricePerCup)
                {
                    currentDay.PotentialCustomers[i].CupsBought = 0;
                }
                else if (currentDay.PotentialCustomers[i].MaxWillingToPay >= lemonade.PricePerCup)
                {
                    if (currentDay.PotentialCustomers[i].LemonPreference == lemonade.LemonAmount && currentDay.PotentialCustomers[i].SugarPreference == lemonade.SugarAmount && currentDay.PotentialCustomers[i].IcePreference == lemonade.IceAmount)
                    {
                        currentDay.PotentialCustomers[i].CupsBought = 3;
                        currentDay.Sales += (3 * currentDay.Lemonade.PricePerCup);
                        currentDay.Customers.Add(currentDay.PotentialCustomers[i]);
                        Inventory.RemoveLemons(3 * lemonade.LemonAmount);
                        Inventory.RemoveSugar(3 * lemonade.SugarAmount);
                        Inventory.RemoveIce(3 * lemonade.IceAmount);
                        Inventory.RemoveCups(3);
                    }
                    else
                    {
                        int amount = random.Next(2);
                        if (amount == 0)
                        {
                            currentDay.PotentialCustomers[i].CupsBought = 0;
                        }
                        else if (amount == 1)
                        {
                            currentDay.PotentialCustomers[i].CupsBought = 1;
                            currentDay.Sales += currentDay.Lemonade.PricePerCup;
                            currentDay.Customers.Add(currentDay.PotentialCustomers[i]);
                            Inventory.RemoveLemons(lemonade.LemonAmount);
                            Inventory.RemoveSugar(lemonade.SugarAmount);
                            Inventory.RemoveIce(lemonade.IceAmount);
                            Inventory.RemoveCups(1);
                        }
                    }
                }
            }
        }
    }
}
