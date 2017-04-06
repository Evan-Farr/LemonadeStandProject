using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        private double maxWillingToPay;
        private int lemonPreference;
        private int sugarPreference;
        private int icePreference;
        private int chanceOfBuying;
        private int cupsBought;
        private Day currentDay;

        public double MaxWillingToPay { get { return maxWillingToPay; } set { maxWillingToPay = value; } }
        public int ChanceOfBuying { get { return chanceOfBuying; } set { chanceOfBuying = value; } }
        public int CupsBought { get { return cupsBought; } set { cupsBought = value; } }

        public Customer(Day currentDay)
        {
            maxWillingToPay = SetMaxWillingToPay();
            chanceOfBuying = DetermineChanceOfBuying();
            this.currentDay = currentDay;
        }

        private double SetMaxWillingToPay()
        {
            Random random = new Random();
            maxWillingToPay = random.NextDouble() * (6 - 1) + 1;
            return maxWillingToPay;
        }

        private int DetermineChanceOfBuying()
        {

            return chanceOfBuying;
        }

        public void BuyLemonade()
        {
            if(maxWillingToPay < currentDay.LemonadePrice)
            {
                cupsBought = 0;
            }else if(maxWillingToPay > currentDay.LemonadePrice)
            {
                Random random = new Random();
                int amount = random.Next(4);
                cupsBought += amount;
                currentDay.Customers.Add(this);
            }
        }
    }
}
