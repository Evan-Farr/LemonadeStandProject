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

        public void RefillInventory()
        {
            UserInterface.DisplayPurchasePrices(new Cup(), new Lemon(), new Sugar(), new Ice());
            Console.WriteLine("Enter amount for each. If you don't need a certain product, enter '0'.");
            Console.WriteLine("Cups: ");
            int cupAmount = int.Parse(Console.ReadLine());
            if (cupAmount != 0)
            {
                Inventory.AddCups(cupAmount);
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine();
            Console.WriteLine("Lemons: ");
            int lemonAmount = int.Parse(Console.ReadLine());
            if (lemonAmount != 0)
            {
                player1.Store.Inventory.AddLemon(lemonAmount, player1, new Lemon());
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine();
            Console.WriteLine("Sugar: ");
            int sugarAmount = int.Parse(Console.ReadLine());
            if (sugarAmount != 0)
            {
                player1.Store.Inventory.AddSugar(sugarAmount, player1, new Sugar());
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine();
            Console.WriteLine("Ice: ");
            int iceAmount = int.Parse(Console.ReadLine());
            if (iceAmount != 0)
            {
                player1.Store.Inventory.AddIce(iceAmount, player1, new Ice());
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine();
            UserInterface.DisplayInventory(player1);
            Console.WriteLine();
        }
    }

        public void SellLemonade(Day currentDay)
        {
            for(int i = 0; i < currentDay.PotentialCustomers.Count; i++)
            {
                if (currentDay.PotentialCustomers[i].MaxWillingToPay < currentDay.Lemonade.PricePerCup)
                {
                    currentDay.PotentialCustomers[i].CupsBought = 0;
                }
                else if (currentDay.PotentialCustomers[i].MaxWillingToPay >= currentDay.Lemonade.PricePerCup)
                {
                    if (currentDay.PotentialCustomers[i].LemonPreference == currentDay.Lemonade.LemonAmount && currentDay.PotentialCustomers[i].SugarPreference == currentDay.Lemonade.SugarAmount && currentDay.PotentialCustomers[i].IcePreference == currentDay.Lemonade.IceAmount)
                    {
                        currentDay.PotentialCustomers[i].CupsBought = 3;
                        currentDay.Sales += (3 * currentDay.Lemonade.PricePerCup);
                        currentDay.Customers.Add(currentDay.PotentialCustomers[i]);
                        Inventory.RemoveLemons(3 * currentDay.Lemonade.LemonAmount);
                        Inventory.RemoveSugar(3 * currentDay.Lemonade.SugarAmount);
                        Inventory.RemoveIce(3 * currentDay.Lemonade.IceAmount);
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
                            Inventory.RemoveLemons(currentDay.Lemonade.LemonAmount);
                            Inventory.RemoveSugar(currentDay.Lemonade.SugarAmount);
                            Inventory.RemoveIce(currentDay.Lemonade.IceAmount);
                            Inventory.RemoveCups(1);
                        }
                    }
                }
            }
        }
    }
}
