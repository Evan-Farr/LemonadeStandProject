using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        private int dayCount;
        public List<Customer> customers;
        private int totalCustomers;

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
            totalCustomers = customers.Count;
        }

        public int DayCount { get { return dayCount; } }

        public int TotalCustomers { get { return totalCustomers; } set { totalCustomers = customers.Count;  } }
    }
}
