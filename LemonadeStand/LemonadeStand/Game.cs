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
        public Day day;
        private double currentScore;
        private double highScore;
        private string gameMode;
        private Random random;

        public double CurrentScore { get { return currentScore; } set { currentScore = value; } }
        public double HighScore { get { return highScore; } set { highScore = value; } }
        public string GameMode { get { return gameMode; } set { gameMode = value; } }

        public void PlayGame()
        {
            random = new Random();
            DisplayPremise();
            GetPlayerName();
            DisplayRules();
            GetGameMode();
            RequestNewGame();
        }

        private void DisplayPremise()
        {
            Console.WriteLine("So you wanna get into the Lemonade Stand racquette?");
            Console.WriteLine("Well then, just a heads-up....");
            Console.WriteLine("Just because little Jimmy down the street is making a killing doesn't mean you will!");
            Console.WriteLine();
        }

        private void GetPlayerName()
        {
            player1 = new Player("Lionel Lemon");
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
            player1.Name = Console.ReadLine();
            Console.WriteLine();
        }

        private void DisplayRules()
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
            else if (gameMode == "2")
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
            DisplayInventory();
            day = new Day();

        }

        private void RunSevenDayGame()
        {
            while(player1.store.DaysOpen != 8)
            {
                RunOneDay();
                DisplayDailyResults();
                DisplayInventory();
                player1.store.DaysOpen += 1;
            }
        }

        private void RunFourteenDayGame()
        {

        }

        private void RunTwentyOneDayGame()
        {

        }

        private void DisplayDailyResults()
        {
            Console.WriteLine();
            Console.WriteLine("THIS DAY IS DONE!");
            Console.WriteLine($"Results from day {player1.store.DaysOpen}: ");
            Console.WriteLine($"Profit/Loss: ");
            Console.WriteLine($">Total Money: ${player1.store.Money}");
            Console.WriteLine($">Customers: {day.TotalCustomers}");
            Console.WriteLine();
        }

        private void DisplayInventory()
        {
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine($"Cups: {player1.store.Inventory.Cups}");
            Console.WriteLine($"Cups: {player1.store.Inventory.Lemons}");
            Console.WriteLine($"Cups: {player1.store.Inventory.Sugar}");
            Console.WriteLine($"Cups: {player1.store.Inventory.Ice}");
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
