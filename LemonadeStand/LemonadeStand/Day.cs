using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather todaysWeather;
        private int dayCount;
        private List<Customer> customers;
        private int totalCustomers;
        public LemonadeRecipe recipe;

        public int DayCount { get { return dayCount; } }
        public int TotalCustomers { get { return totalCustomers; } set { totalCustomers = customers.Count; } }
        public int Customers { get { return customers.Count; } }

        public Day()
        {
            todaysWeather = new Weather();
            customers = new List<Customer>();
            totalCustomers = customers.Count;
            recipe = new LemonadeRecipe();
        }
    }
}
