using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemonade
    {
        private int lemonAmount;
        private int iceAmount;
        private int sugarAmount;
        private double pricePerCup;

        public int LemonAmount { get { return lemonAmount; } }
        public int IceAmount { get { return iceAmount; } }
        public int SugarAmount { get { return sugarAmount; } }
        public double PricePerCup { get { return pricePerCup; } set { pricePerCup = value; } }

        public Lemonade()
        {
            lemonAmount = 2;
            iceAmount = 2;
            sugarAmount = 2;
            pricePerCup = 2.00;
            GetRecipe();
        }

        public void GetRecipe()
        {
            GetLemonAmount();
            GetSugarAmount();
            GetIceAmount();
            DisplayRecipe();
        }

        private void GetLemonAmount()
        {
            Console.WriteLine("How many lemons should be in each glass? Enter the amount: ");
            lemonAmount = int.Parse(Console.ReadLine());
        }

        private void GetSugarAmount()
        {
            Console.WriteLine("How much sugar should be in each glass? Enter the amount: ");
            sugarAmount = int.Parse(Console.ReadLine());
        }

        private void GetIceAmount()
        {
            Console.WriteLine("How many ice cubes should be in each glass? Enter the amount: ");
            iceAmount = int.Parse(Console.ReadLine());
        }

        private void DisplayRecipe()
        {
            Console.WriteLine("Ingredients per cup of Lemonade: ");
            Console.WriteLine($"Lemons: {lemonAmount}");
            Console.WriteLine($"Sugar: {sugarAmount}");
            Console.WriteLine($"Ice: {iceAmount}");
            Console.WriteLine();
        }

        public void SetLemonadePrice()
        {
            Console.WriteLine($"Default price per cup of lemonade: ${pricePerCup}");
            Console.WriteLine("Would you like to change this price? Enter 'yes' or 'no'.");
            string alter = Console.ReadLine();

            if (alter == "yes")
            {
                Console.WriteLine("Enter the amount you want to charge for each cup: ");
                pricePerCup = double.Parse(Console.ReadLine());
            }
            else if (alter == "no")
            {
                pricePerCup = 2.00;
            }
            else if (alter != "yes" && alter != "no")
            {
                Console.WriteLine("You did not enter a valid response. Please enter only 'yes' or 'no' as a response.");
                Console.WriteLine();
                SetLemonadePrice();
            }
        }
    }
}
