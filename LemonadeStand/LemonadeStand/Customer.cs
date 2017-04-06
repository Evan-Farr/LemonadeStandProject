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
        private int chanceOfBuying;
        private int cupsBought;

        public double MaxWillingToPay { get { return maxWillingToPay; } set { maxWillingToPay = value; } }
        public int ChanceOfBuying { get { return chanceOfBuying; } set { chanceOfBuying = value; } }
        public int CupsBought { get { return cupsBought; } set { cupsBought = value; } }

        public Customer()
        {
            maxWillingToPay = GetMaxWillingToPay();
            chanceOfBuying = DetermineChanceOfBuying();
        }

        private double GetMaxWillingToPay()
        {
            return maxWillingToPay;
        }

        private int DetermineChanceOfBuying()
        {
            return chanceOfBuying;
        }
    }
}
