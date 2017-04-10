using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void DisplayPremise()
        {
            Console.WriteLine("So you wanna get into the Lemonade Stand racquette?");
            Console.WriteLine("Well then, just a heads-up....");
            Console.WriteLine("Just because little Jimmy down the street is making a killing doesn't mean you will!");
            Console.WriteLine();
        }

        public static void DisplayRules(Player player1)
        {
            Console.WriteLine($"Ok {player1.Name}, here's how this works...");
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14 or 21 days by selling lemonade at your new stand.");
            Console.WriteLine("You'll need to buy cups, lemons, sugar and ice to keep your inventory full.");
            Console.WriteLine("You start with $200 and an empty inventory.");
            Console.WriteLine("You set the price and recipe, which should be based on the weather and customer buying habits.");
            Console.WriteLine("It's recommended to begin using the pre-built recipe to get the hang of it, then vary from there.");
            Console.WriteLine("Then, set your price and start selling some lemonade!");
            Console.WriteLine("At the end of the game, you'll see how much money you made. That profit or loss is your score.");
            Console.WriteLine("Then, play again and again until your highscore is impossible for your friends to beat!");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void DisplayInventory(Player player1)
        {
            Console.WriteLine();
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine($"Cups: {player1.Store.Inventory.Cups}");
            Console.WriteLine($"Lemons: {player1.Store.Inventory.Lemons}");
            Console.WriteLine($"Sugar: {player1.Store.Inventory.Sugar}");
            Console.WriteLine($"Ice: {player1.Store.Inventory.Ice}");
            Console.WriteLine();
        }

        public static void AlertEmptyInventoryItem(string product)
        {
            
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"This day ended early because you ran out of {product} in your inventory!");
            Console.WriteLine("Make sure you have enough of each ingredient before starting a new day.");

        }

        public static void DisplayCash(Player player1)
        {
            Console.WriteLine($"Your Money: ${player1.Store.Money}");
        }

        public static void DisplayPurchasePrices(Cup cup, Lemon lemon, Sugar sugar, Ice ice)
        {
            Console.WriteLine();
            Console.WriteLine("Cost to buy:");
            Console.WriteLine($"Cup: ${cup.Price}");
            Console.WriteLine($"Lemon: ${lemon.Price}");
            Console.WriteLine($"Sugar: ${sugar.Price}");
            Console.WriteLine($"Ice: ${ice.Price}");
            Console.WriteLine();
        }

        public static void DisplayDailyResults(Player player1, Day currentDay)
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Results from day {player1.Store.DaysOpen}: ");
            Console.WriteLine($">Total Sales: ${currentDay.Sales}");
            Console.WriteLine($">Customers: {currentDay.TotalCustomers}");
            Console.WriteLine($">Today's Profit/Loss: ${player1.Store.DailyProfitLoss}");
            if(player1.Store.Money < 500)
            {
                Console.WriteLine($">Cumulative Profit/Loss: - ${player1.Store.RunningProfitLoss}");
            }else if(player1.Store.Money > 500)
            {
                Console.WriteLine($">Cumulative Profit/Loss: + ${player1.Store.RunningProfitLoss}");
            }
            Console.WriteLine();
        }

        public static void DisplayEndResults(int gameLength, Player player1, int day)
        {
            if (player1.Store.DaysOpen != gameLength)
            {
                Console.WriteLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("Unfortunely you ran out of both money and cups. Without those there's no way to keep the business open.");
                Console.WriteLine();
                Console.WriteLine("Results: ");
                Console.WriteLine($"Your business lasted until day {player1.Store.DaysOpen} out of {day}.");
                Console.WriteLine("Starting Money: $500");
                Console.WriteLine($"Ending Money: ${player1.Store.Money}");
                Console.WriteLine($"Final Score: {player1.Store.Money}");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("GAME OVER. Congradulations on making it without having to close the store!");
                Console.WriteLine();
                Console.WriteLine("Results: ");
                Console.WriteLine($"Your business lasted until day {player1.Store.DaysOpen} out of {day}.");
                Console.WriteLine("Starting Money: $500");
                Console.WriteLine($"Ending Money: ${player1.Store.Money}");
                Console.WriteLine($"Final Score: {player1.Store.Money}");
                Console.WriteLine();
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine();
            }
        }
    }
}
