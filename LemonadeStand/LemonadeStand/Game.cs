using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Player player1;
        private string gameMode;
        private Random random;

        public string GameMode { get { return gameMode; } set { gameMode = value; } }

        public void PlayGame()
        {
            random = new Random();
            UserInterface.DisplayPremise();
            GetPlayerName();
            UserInterface.DisplayRules(player1);
            GetGameMode();
            UserInterface.RequestNewGame(new Game());
        }

        private void GetPlayerName()
        {
            player1 = new Player("Lionel Lemon", random);
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
            player1.Name = Console.ReadLine();
            Console.WriteLine();
        }

        private void GetGameMode()
        {
            Console.WriteLine("CHOOSE GAME DURATION: ");
            Console.WriteLine("Enter '1', '2' or '3': ");
            Console.WriteLine("[1] 7 days");
            Console.WriteLine("[2] 14 days");
            Console.WriteLine("[3] 21 days");
            gameMode = Console.ReadLine();
            if (gameMode == "1")
            {
                RunSevenDayGame();
            }
            else if (gameMode == "2")
            {
                RunFourteenDayGame();
            }
            else if (gameMode == "3")
            {
                RunTwentyOneDayGame();
            }
            Console.WriteLine();
            if (gameMode != "1" && gameMode != "2" && gameMode != "3")
            {
                Console.WriteLine("You did not enter a valid choice. Please enter only '1', '2' or '3'.");
                GetGameMode();
            }
        }

        private void RunOneDay()
        {
            UserInterface.DisplayCash(player1);
            UserInterface.DisplayInventory(player1);
            RequestInventoryRefill();
            Day currentDay = new Day(random);
            Lemonade lemonade = new Lemonade();
            player1.Store.SellLemonade(lemonade, currentDay);
            UserInterface.DisplayDailyResults(player1, currentDay);
            player1.Store.DaysOpen += 1;
        }

        private void RunSevenDayGame()
        {
            while(player1.Store.DaysOpen != 8)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunOneDay();
            }
            DisplayEndResults();
        }

        private void RunFourteenDayGame()
        {

        }

        private void RunTwentyOneDayGame()
        {

        }

        private void RequestInventoryRefill()
        {
            Console.WriteLine("Do you want to re-fill your inventory? Enter 'yes' or 'no': ");
            string response = Console.ReadLine();
            if(response == "yes")
            {
                UserInterface.DisplayInventory(player1);
                UserInterface.DisplayPurchasePrices(new Cup(), new Lemon(), new Sugar(), new Ice());
                Console.WriteLine();
                Console.WriteLine("Enter amount for each. If you don't need a certain product, enter '0'.");
                Console.WriteLine("Cups: ");
                int cupAmount = int.Parse(Console.ReadLine());
                if(cupAmount != 0)
                {
                    player1.Store.Inventory.AddCups(cupAmount, player1, new Cup());
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
            }
        }

        private void DisplayEndResults()
        {

        }
    }
}
