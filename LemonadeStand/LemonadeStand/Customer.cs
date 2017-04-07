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
        private Random random;

        public double MaxWillingToPay { get { return maxWillingToPay; } }
        public int LemonPreference { get { return lemonPreference; } }
        public int SugarPreference { get { return sugarPreference; } }
        public int IcePreference { get { return icePreference; } }
        public int ChanceOfBuying { get { return chanceOfBuying; } }
        public int CupsBought { get { return cupsBought; } set { cupsBought = value; } }

        public Customer(Random Random)
        {
            random = Random;
            maxWillingToPay = SetMaxWillingToPay();
            chanceOfBuying = DetermineChanceOfBuying();
            lemonPreference = SetLemonPreference();
            sugarPreference = SetSugarPreference();
            icePreference = SetIcePreference();
            cupsBought = 0;
        }

        private double SetMaxWillingToPay()
        {
            maxWillingToPay = random.NextDouble() * (6 - 1) + 1;
            maxWillingToPay = Math.Round(maxWillingToPay, 2);
            return maxWillingToPay;
        }

        private int DetermineChanceOfBuying()
        {
            int amount = random.Next(11);
            return chanceOfBuying;
        }

        private int SetLemonPreference()
        {
            lemonPreference = random.Next(1, 5);
            return lemonPreference;
        }

        private int SetSugarPreference()
        {
            sugarPreference = random.Next(1, 6);
            return sugarPreference;
        }

        private int SetIcePreference()
        {
            icePreference = random.Next(1, 10);
            return icePreference;
        }
    }
}
