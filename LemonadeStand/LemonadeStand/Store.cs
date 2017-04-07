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

        public void SellLemonade(Customer customer, Lemonade lemonade, Day currentDay)
        {
            if (customer.MaxWillingToPay < lemonade.PricePerCup)
            {
                customer.CupsBought = 0;
            }
            else if (customer.MaxWillingToPay >= lemonade.PricePerCup)
            {
                if (customer.LemonPreference == lemonade.LemonAmount && customer.SugarPreference == lemonade.SugarAmount && customer.IcePreference == lemonade.IceAmount)
                {
                    customer.CupsBought = 3;
                    currentDay.Sales += (3 * currentDay.Lemonade.PricePerCup);
                    currentDay.Customers.Add(customer);
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
                        customer.CupsBought = 0;
                    }
                    else if (amount == 1)
                    {
                        customer.CupsBought = 1;
                        currentDay.Sales += currentDay.Lemonade.PricePerCup;
                        currentDay.Customers.Add(customer);
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
