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
            Day currentDay = new Day(random);
            RequestInventoryRefill(currentDay);
            player1.Store.SellLemonade(currentDay);
            UserInterface.DisplayDailyResults(player1, currentDay);
            player1.Store.DaysOpen += 1;
            player1.Store.UpdateMoney(currentDay.Sales);
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
            while (player1.Store.DaysOpen != 15)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunOneDay();
            }
            DisplayEndResults();
        }

        private void RunTwentyOneDayGame()
        {
            while (player1.Store.DaysOpen != 22)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunOneDay();
            }
            DisplayEndResults();
        }

        private void RequestInventoryRefill(Day currentDay)
        {
            Console.WriteLine("Do you want to re-fill your inventory? Enter 'yes' or 'no': ");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                player1.Store.RefillInventory(currentDay);
            }else if(response == "no")
            {
                Console.WriteLine();
            }else if (response != "yes" && response != "no")
            {
                Console.WriteLine("You did not enter a valid response. Please enter only 'yes' or 'no' as a response.");
                Console.WriteLine();
                RequestInventoryRefill(currentDay);
            }
        }

        private void DisplayEndResults()
        {

        }
    }
}
