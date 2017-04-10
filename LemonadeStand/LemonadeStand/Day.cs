using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {

        private Weather todaysWeather;
        private List<Customer> customers;
        private List<Customer> potentialCustomers;
        private double sales;
        private Random random;

        public Weather TodaysWeather { get { return todaysWeather; } }
        //public Lemonade Lemonade { get { return lemonade; } }
        public int TotalCustomers { get { return customers.Count; } }
        public List<Customer> Customers { get { return customers; } set { customers = value; } }
        public List<Customer> PotentialCustomers { get { return potentialCustomers; } set { potentialCustomers = value; } }
        public double Sales { get { return sales; } set { sales = value; } }

        public Day(Random Random)
        {
            random = Random;
            todaysWeather = new Weather(random);
            customers = new List<Customer>();
            potentialCustomers = new List<Customer>();
            SetPotentialCustomers();
            sales = 0;
        }

        private void SetPotentialCustomers()
        {
            if(todaysWeather.LemonadeDemand == "low")
            {
                while(potentialCustomers.Count <= 50)
                {
                    potentialCustomers.Add(new Customer(random));
                }
            }else if(todaysWeather.LemonadeDemand == "medium")
            {
                while(potentialCustomers.Count <= 100)
                {
                    potentialCustomers.Add(new Customer(random));
                }
            }
            else if (todaysWeather.LemonadeDemand == "high")
            {
                while (potentialCustomers.Count <= 150)
                {
                    potentialCustomers.Add(new Customer(random));
                }
            }
            else if (todaysWeather.LemonadeDemand == "very high")
            {
                while (potentialCustomers.Count <= 200)
                {
                    potentialCustomers.Add(new Customer(random));
                }
            }
        }
    }
}
