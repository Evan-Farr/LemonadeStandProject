using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Player player;
        private double currentScore;
        private double highScore;

        public double CurrentScore { get { return currentScore; } set { currentScore = value; } }
        public double HighScore { get { return highScore; } set { highScore = value; } }

        public Game()
        {
            DisplayPremise();
            GetPlayerName();
            DisplayRules();
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
            Player player = new Player("Lionel Lemon");
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine();
        }

        private void DisplayRules()
        {
            Console.WriteLine($"Ok {player.Name}, here's how this works...");
            Console.WriteLine("Your goal is to make as much money as you can in 7 days by selling lemonade at your new stand.");
            Console.WriteLine("You'll need to buy cups, lemons, sugar and ice to keep your inventory full.");
            Console.WriteLine("Now, you may love your Grandma's secret-recipe lemonade, but don't rely on that in this game!");
            Console.WriteLine("You set the price and recipe, which should be based on the weather conditions.");
            Console.WriteLine("Start with the pre-built recipe to get the hang of the game. Then vary it from there.");
            Console.WriteLine("Lastly, set your price and start selling some lemonade!");
            Console.WriteLine("At the end of the game (7 days), you'll see how much money you made. That profit or loss is your score.");
            Console.WriteLine("Then, play again and again until your highscore is impossible for your friends to beat!");
            Console.WriteLine();
        }
    }
}
