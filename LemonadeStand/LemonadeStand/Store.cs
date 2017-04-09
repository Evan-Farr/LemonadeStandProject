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

        public void RefillInventory()
        {
            UserInterface.DisplayPurchasePrices(new Cup(), new Lemon(), new Sugar(), new Ice());
            Console.WriteLine("Enter amount for each. If you don't need a certain product, enter '0'.");
            RefillCups();
            UserInterface.DisplayCash(player1);
            RefillLemons();
            UserInterface.DisplayCash(player1);
            RefillSugar();
            UserInterface.DisplayCash(player1);
            RefillIce();
            UserInterface.DisplayCash(player1);
            Console.WriteLine();
            Console.WriteLine("Inventory updated.");
            UserInterface.DisplayInventory(player1);
            Console.WriteLine();
        }

        private void RefillCups()
        {
            Console.WriteLine("Cups: ");
            int cupAmount = int.Parse(Console.ReadLine());
            if (cupAmount != 0)
            {
                if ((cupAmount * new Cup().Price) > player1.Store.Money)
                {
                    Console.WriteLine("You don't have enough money to buy that many cups. Please try again.");
                    UserInterface.DisplayCash(player1);
                    RefillCups();
                }
                else
                {
                    inventory.AddCups(cupAmount);
                    dailyExpenses += (cupAmount * new Cup().Price);
                    money -= (cupAmount * new Cup().Price);
                }
            }
        }

        private void RefillLemons()
        {
            Console.WriteLine("Lemons: ");
            int lemonAmount = int.Parse(Console.ReadLine());
            if (lemonAmount != 0)
            {
                if ((lemonAmount * new Lemon().Price) > player1.Store.Money)
                {
                    Console.WriteLine("You don't have enough money to buy that many lemons. Please try again.");
                    UserInterface.DisplayCash(player1);
                    RefillLemons();
                }else
                {
                    inventory.AddLemon(lemonAmount);
                    dailyExpenses += (lemonAmount * new Lemon().Price);
                    money -= (lemonAmount * new Lemon().Price);
                }
            }
        }

        private void RefillSugar()
        {
            Console.WriteLine("Sugar: ");
            int sugarAmount = int.Parse(Console.ReadLine());
            if (sugarAmount != 0)
            {
                if ((sugarAmount * new Sugar().Price) > player1.Store.Money)
                {
                    Console.WriteLine("You don't have enough money to buy that many cubes of sugar. Please try again.");
                    UserInterface.DisplayCash(player1);
                    RefillSugar();
                }else
                {
                    inventory.AddSugar(sugarAmount);
                    dailyExpenses += (sugarAmount * new Sugar().Price);
                    money -= (sugarAmount * new Sugar().Price);
                }
            }
        }

        private void RefillIce()
        {
            Console.WriteLine("Ice: ");
            int iceAmount = int.Parse(Console.ReadLine());
            if (iceAmount != 0)
            {
                if ((iceAmount * new Ice().Price) > player1.Store.Money)
                {
                    Console.WriteLine("You don't have enough money to buy that many ice cubes. Please try again.");
                    UserInterface.DisplayCash(player1);
                    RefillIce();
                }
                else
                {
                    inventory.AddIce(iceAmount);
                    dailyExpenses += (iceAmount * new Ice().Price);
                    money -= (iceAmount * new Ice().Price);
                }
            }
        }

        public void SellLemonade(Day currentDay, Lemonade lemonade)
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
                        currentDay.Sales += (3 * lemonade.PricePerCup);
                        currentDay.Customers.Add(currentDay.PotentialCustomers[i]);
                        if(!inventory.RemoveLemons(3 * lemonade.LemonAmount))
                        {
                            UserInterface.AlertEmptyInventoryItem("lemons");
                            break;
                        }
                        if (!inventory.RemoveSugar(3 * lemonade.SugarAmount))
                        {
                            UserInterface.AlertEmptyInventoryItem("sugar");
                            break;
                        }
                        if (!inventory.RemoveIce(3 * lemonade.IceAmount))
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
                            currentDay.Sales += lemonade.PricePerCup;
                            currentDay.Customers.Add(currentDay.PotentialCustomers[i]);
                            if (!inventory.RemoveLemons(lemonade.LemonAmount))
                            {
                                UserInterface.AlertEmptyInventoryItem("lemons");
                                break;
                            }
                            if (!inventory.RemoveSugar(lemonade.SugarAmount))
                            {
                                UserInterface.AlertEmptyInventoryItem("sugar");
                                break;
                            }
                            if (!inventory.RemoveIce(lemonade.IceAmount))
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

        public void CalculateDailyProfitLoss(double dailySales)
        {
            dailyProfitLoss = dailySales - dailyExpenses;
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
