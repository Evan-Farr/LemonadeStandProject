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

        public void PlayGame()
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
            player = new Player("Lionel Lemon");
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
            player.Name = Console.ReadLine();
            Console.WriteLine();
        }

        private void DisplayRules()
        {
            Console.WriteLine($"Ok {player.Name}, here's how this works...");
            Console.WriteLine("Your goal is to make as much money as you can in 7, 14 or 21 days by selling lemonade at your new stand.");
            Console.WriteLine("You'll need to buy cups, lemons, sugar and ice to keep your inventory full.");
            Console.WriteLine("You start with $200 and an empty inventory.");
            Console.WriteLine("You set the price and recipe, which should be based on the weather and customer buying habits.");
            Console.WriteLine("It's recommended to begin using the pre-built recipe and price to get the hang of it, then vary from there.");
            Console.WriteLine("Lastly, set your price and start selling some lemonade!");
            Console.WriteLine("At the end of the game, you'll see how much money you made. That profit or loss is your score.");
            Console.WriteLine("Then, play again and again until your highscore is impossible for your friends to beat!");
            Console.WriteLine();
        }
    }
}
