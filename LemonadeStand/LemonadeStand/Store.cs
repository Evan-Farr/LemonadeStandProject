using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public Inventory inventory;
        private double money;
        private double dailyProfitLoss;
        private double runningProfitLoss;
        private int daysOpen;

        public double Money { get { return money; } }
        public double DailyProfitLoss { get { return dailyProfitLoss; } set { dailyProfitLoss = value; } }
        public double RunningProfitLoss { get { return runningProfitLoss; } set { runningProfitLoss = value; } }
        public int DayCount { get { return daysOpen; } set { daysOpen = value; } }

        public Store()
        {
            inventory = new Inventory();
            money = 200;
            daysOpen = 0;
        }

        public void SellLemonade(Customer customer)
        {

        }
    }
}
