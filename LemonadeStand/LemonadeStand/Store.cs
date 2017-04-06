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
        private Day currentDay;
        private Customer customer;
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

        public void SellLemonade(Customer customer, Day currentDay)
        {
            if (customer.MaxWillingToPay < currentDay.LemonadePrice)
            {
                customer.CupsBought = 0;
            }
            else if (customer.MaxWillingToPay >= currentDay.LemonadePrice)
            {
                if (customer.LemonPreference == currentDay.Recipe.LemonAmount && customer.SugarPreference == currentDay.Recipe.SugarAmount && customer.IcePreference == currentDay.Recipe.IceAmount)
                {
                    customer.CupsBought = 3;
                    currentDay.Sales += (3 * currentDay.LemonadePrice);
                    currentDay.Customers.Add(customer);
                    Inventory.RemoveLemons(3 * currentDay.Recipe.LemonAmount);
                    Inventory.RemoveSugar(3 * currentDay.Recipe.SugarAmount);
                    Inventory.RemoveIce(3 * currentDay.Recipe.IceAmount);
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
                        currentDay.Sales += currentDay.LemonadePrice;
                        currentDay.Customers.Add(customer);
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
