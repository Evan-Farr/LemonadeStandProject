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
        private double budget;
        public double dailySales;
        public double runningSales;
        
        public Store()
        {
            inventory = new Inventory();
            budget = 200;
        }

        public void SellLemonade(Customer customer)
        {

        }
        
        public bool Withdraw(double Amount)
        {
            if (Amount > budget)
            {
                return false;
            }
            budget -= Amount;
            return true;
        }

        public double GetBudget()
        {
            return budget;
        }
    }
}
