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
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
            player.Name = Console.ReadLine();
        }

        private void DisplayRules()
        {
            Console.WriteLine($"Ok {player.Name}, here's how this works...");
            Console.WriteLine("First, before I can give you a stand, I'll need to know your name.");
            Console.WriteLine("Enter your name: ");
        }
    }
}
