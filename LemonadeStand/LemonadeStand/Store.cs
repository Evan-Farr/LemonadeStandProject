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
        private Player player1;
        private double dailyExpenses;

        public Inventory Inventory { get { return inventory; } }
        public double Money { get { return money; } set { money = value; } }
        public double DailyProfitLoss { get { return dailyProfitLoss; } set { dailyProfitLoss = value; } }
        public double RunningProfitLoss { get { return runningProfitLoss; } set { runningProfitLoss = value; } }
        public int DaysOpen { get { return daysOpen; } set { daysOpen = value; } }
        public double DailyExpenses { get { return dailyExpenses; } set { dailyExpenses = value; } }

        public Store(Random Random, Player Player1)
        {
            random = Random;
            inventory = new Inventory();
            money = 500;
            daysOpen = 1;
            player1 = Player1;
        }

        public void RefillInventory(Day currentDay)
        {
            dailyExpenses = 0;
            UserInterface.DisplayPurchasePrices(new Cup(), new Lemon(), new Sugar(), new Ice());
            Console.WriteLine("Enter amount for each. If you don't need a certain product, enter '0'.");
            Console.WriteLine("Cups: ");
            int cupAmount = int.Parse(Console.ReadLine());
            if (cupAmount != 0)
            {
                inventory.AddCups(cupAmount);
<<<<<<< HEAD
                dailyExpenses += (cupAmount * new Cup().Price);
=======
                currentDay.DailyExpenses += (cupAmount * new Cup().Price);
>>>>>>> 0cea48210471ebe7147af7a21dc5a5868208c7ad
                money -= (cupAmount * new Cup().Price);
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine("Lemons: ");
            int lemonAmount = int.Parse(Console.ReadLine());
            if (lemonAmount != 0)
            {
                inventory.AddLemon(lemonAmount);
                dailyExpenses += (lemonAmount * new Cup().Price);
                money -= (cupAmount * new Lemon().Price);
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine("Sugar: ");
            int sugarAmount = int.Parse(Console.ReadLine());
            if (sugarAmount != 0)
            {
                inventory.AddSugar(sugarAmount);
                dailyExpenses += (sugarAmount * new Cup().Price);
                money -= (cupAmount * new Sugar().Price);
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine("Ice: ");
            int iceAmount = int.Parse(Console.ReadLine());
            if (iceAmount != 0)
            {
                inventory.AddIce(iceAmount);
                dailyExpenses += (iceAmount * new Cup().Price);
                money -= (cupAmount * new Ice().Price);
            }
            UserInterface.DisplayCash(player1);
            Console.WriteLine("Inventory updated.");
            UserInterface.DisplayInventory(player1);
            Console.WriteLine();
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
                        if(!inventory.RemoveLemons(3 * currentDay.Lemonade.LemonAmount))
                        {
                            UserInterface.AlertEmptyInventoryItem("lemons");
                            break;
                        }
                        if (!inventory.RemoveSugar(3 * currentDay.Lemonade.SugarAmount))
                        {
                            UserInterface.AlertEmptyInventoryItem("sugar");
                            break;
                        }
                        if (!inventory.RemoveIce(3 * currentDay.Lemonade.IceAmount))
                        {
                            UserInterface.AlertEmptyInventoryItem("ice");
                            break;
                        }
                        if (!inventory.RemoveCups(3))
                        {
                            UserInterface.AlertEmptyInventoryItem("cups");
                            break;
                        }
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
                            if (!inventory.RemoveLemons(currentDay.Lemonade.LemonAmount))
                            {
                                UserInterface.AlertEmptyInventoryItem("lemons");
                                break;
                            }
                            if (!inventory.RemoveSugar(currentDay.Lemonade.SugarAmount))
                            {
                                UserInterface.AlertEmptyInventoryItem("sugar");
                                break;
                            }
                            if (!inventory.RemoveIce(currentDay.Lemonade.IceAmount))
                            {
                                UserInterface.AlertEmptyInventoryItem("ice");
                                break;
                            }
                            if (!inventory.RemoveCups(1))
                            {
                                UserInterface.AlertEmptyInventoryItem("cups");
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void UpdateMoney(double sales)
        {
            money += sales;
        }

        public void CalculateDailyProfitLoss(double dailySales, Day currentDay)
        {
<<<<<<< HEAD
            dailyProfitLoss = dailySales - dailyExpenses;
=======
            dailyProfitLoss = dailySales - currentDay.DailyExpenses;
>>>>>>> 0cea48210471ebe7147af7a21dc5a5868208c7ad
        }

        public void CalculateRunningProfitLoss(double dailySales)
        {
            if (money < 500)
            {
                runningProfitLoss = 500 - money;
            }
            else if (money > 500)
            {
                runningProfitLoss = ((money + dailySales) - 500);
            }
        }
    }
}
