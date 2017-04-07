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
        private Day currentDay;
        private double currentScore;
        private double highScore;
        private string gameMode;
        private Random random;
        private Cup cup;
        private Lemon lemon;
        private Ice ice;
        private Sugar sugar;

        public double CurrentScore { get { return currentScore; } set { currentScore = value; } }
        public double HighScore { get { return highScore; } set { highScore = value; } }
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
            
            currentDay = new Day(random);
        }

        private void RunSevenDayGame()
        {
            while(player1.Store.DaysOpen != 8)
            {
                Console.WriteLine();
                Console.WriteLine();
                RunOneDay();
                UserInterface.DisplayDailyResults(player1, currentDay);
                UserInterface.DisplayInventory(player1);
                player1.Store.DaysOpen += 1;
            }
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
                DisplayPurchasePrices();
                Console.WriteLine("Enter amount for each. If you don't want to buy any of a certain product, enter '0'.");
                Console.WriteLine("Cups: ");
                int cupAmount = int.Parse(Console.ReadLine());
                if(cupAmount != 0)
                {
                    player1.Store.Inventory.AddCups(cupAmount);
                }
                Console.WriteLine("Lemons: ");
                int lemonAmount = int.Parse(Console.ReadLine());
                if (lemonAmount != 0)
                {
                    player1.Store.Inventory.AddLemon(lemonAmount);
                }
                Console.WriteLine("Sugar: ");
                int sugarAmount = int.Parse(Console.ReadLine());
                if (sugarAmount != 0)
                {
                    player1.Store.Inventory.AddSugar(sugarAmount);
                }
                Console.WriteLine("Ice: ");
                int iceAmount = int.Parse(Console.ReadLine());
                if (iceAmount != 0)
                {
                    player1.Store.Inventory.AddIce(iceAmount);
                }
            }
        }

        private void DisplayPurchasePrices()
        {
            Console.WriteLine();
            Console.WriteLine("Cost to buy:");
            Console.WriteLine($"Cup: ${cup.Price}");
            Console.WriteLine($"Lemon: ${cup.Price}");
            Console.WriteLine($"Sugar: ${cup.Price}");
            Console.WriteLine($"Ice: ${cup.Price}");
            Console.WriteLine();
        }

        private void DisplayEndResults()
        {

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
