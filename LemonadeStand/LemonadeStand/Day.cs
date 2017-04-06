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
        private int totalCustomers;
        private Lemonade lemonade;
        private double lemonadePrice;
        private double sales;

        public Weather TodaysWeather { get { return todaysWeather; } }
        public Lemonade Lemonade { get { return lemonade; } }
        public int TotalCustomers { get { return customers.Count; } }
        public double LemonadePrice { get { return lemonadePrice; } }
        public List<Customer> Customers { get { return customers; } }
        public double Sales { get { return sales; } set { sales = value; } }

        public Day(Random random)
        {
            todaysWeather = new Weather(random);
            customers = new List<Customer>();
            totalCustomers = customers.Count;
            lemonade = new Lemonade();
            sales = 0;
        }
    }
}
