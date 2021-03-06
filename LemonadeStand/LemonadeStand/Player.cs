﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        private string name;
        private Store store;
        private double finalScore;
        private double highScore;

        public string Name { get { return name; } set { name = value; } }
        public Store Store { get { return store; } }
        public double FinalScore { get { return finalScore; } set { finalScore = value; } }
        public double HighScore { get { return highScore; } set { highScore = value; } }

        public Player(string Name, Random random)
        {
            name = Name;
            store = new Store(random, this);
        }
    }
}
