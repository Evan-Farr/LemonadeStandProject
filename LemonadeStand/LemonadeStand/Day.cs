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
        private LemonadeRecipe recipe;
        private double lemonadePrice;
        private double sales;

        public Weather TodaysWeather { get { return todaysWeather; } }
        public LemonadeRecipe Recipe { get { return recipe; } }
        public int TotalCustomers { get { return customers.Count; } }
        public double LemonadePrice { get { return lemonadePrice; } }
        public List<Customer> Customers { get { return customers; } }
        public double Sales { get { return sales; } set { sales = value; } }

        public Day()
        {
            todaysWeather = new Weather();
            customers = new List<Customer>();
            totalCustomers = customers.Count;
            recipe = new LemonadeRecipe();
            lemonadePrice = 2.00;
            sales = 0;
        }

        public void SetLemonadePrice()
        {
            Console.WriteLine($"Default price per cup of lemonade: ${lemonadePrice}");
            Console.WriteLine("Would you like to change this price? Enter 'yes' or 'no'.");
            string alter = Console.ReadLine();

            if(alter == "yes")
            {
                Console.WriteLine("Enter the amount you want to charge for each cup: ");
                lemonadePrice = double.Parse(Console.ReadLine());
            }else if(alter == "no")
            {
                lemonadePrice = 2.00;
            }else if(alter != "yes" && alter != "no")
            {
                Console.WriteLine("You did not enter a valid response. Please enter only 'yes' or 'no' as a response.");
                Console.WriteLine();
                SetLemonadePrice();
            }
        }
    }
}
