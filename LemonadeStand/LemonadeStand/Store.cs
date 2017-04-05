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
        private double dailySales;
        private double runningSales;

        public double Money { get { return money; } }

        public Store()
        {
            inventory = new Inventory();
            money = 200;
        }

        public void SellLemonade(Customer customer)
        {

        }
        
        public bool Withdraw(double Amount)
        {
            if (Amount > money)
            {
                return false;
            }
            money -= Amount;
            return true;
        }
    }
}
