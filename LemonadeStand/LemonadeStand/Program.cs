using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game lemonadeStand = new Game();
            lemonadeStand.PlayGame();
            Console.ReadLine();
        }
    }
}
