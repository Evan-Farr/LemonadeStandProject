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
            RequestNewGame();
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
            Day currentDay = new Day(random);
            RequestInventoryRefill();
            Lemonade recipe = new Lemonade();
            player1.Store.SellLemonade(currentDay, recipe);
            player1.Store.CalculateDailyProfitLoss(currentDay.Sales);
            player1.Store.CalculateRunningProfitLoss(currentDay.Sales);
            UserInterface.DisplayDailyResults(player1, currentDay);
            player1.Store.DaysOpen += 1;
            player1.Store.UpdateMoney(currentDay.Sales);
        }

        private void RunSevenDayGame()
        {
            while(player1.Store.DaysOpen != 8 && player1.Store.Money >= 0 && player1.Store.Inventory.Cups != 0)
            {
                Console.WriteLine();
                RunOneDay();
            }
            UserInterface.DisplayEndResults(8, player1, 7);
            RequestNewGame();
        }

        private void RunFourteenDayGame()
        {
            while (player1.Store.DaysOpen != 15)
            {
                Console.WriteLine();
                RunOneDay();
            }
            UserInterface.DisplayEndResults(15, player1, 14);
        }

        private void RunTwentyOneDayGame()
        {
            while (player1.Store.DaysOpen != 22)
            {
                Console.WriteLine();
                RunOneDay();
            }
            UserInterface.DisplayEndResults(22, player1, 21);
        }

        private void RequestInventoryRefill()
        {
            Console.WriteLine("Do you want to re-fill your inventory? Enter 'yes' or 'no': ");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                if(player1.Store.Money <= 0)
                {
                    Console.WriteLine("It looks like you don't have any money left to spend.");
                    Console.WriteLine("As long as you have some inventory left, try selling it to get out of the hole!");
                    player1.Store.DailyExpenses = 0;
                    Console.WriteLine();
                }else
                {
                    player1.Store.DailyExpenses = 0;
                    player1.Store.RefillInventory();
                }
            }else if(response == "no")
            {
                player1.Store.DailyExpenses = 0;
                Console.WriteLine();
            }else if (response != "yes" && response != "no")
            {
                Console.WriteLine("You did not enter a valid response. Please enter only 'yes' or 'no' as a response.");
                Console.WriteLine();
                RequestInventoryRefill();
            }
        }

        private void RequestNewGame()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to play again? Enter 'yes' or 'no'.");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                Console.Clear();
                PlayGame();
            }
            else if (response == "no")
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hit [Enter] to quite.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You did not enter a valid input. Please type only 'yes' or 'no' as an answer.");
                Console.WriteLine();
                RequestNewGame();
            }
        }
    }
}
