using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class LemonadeRecipe
    {
        private int lemonAmount;
        private int iceAmount;
        private int sugarAmount;

        public int LemonAmount { get { return lemonAmount; } }
        public int IceAmount { get { return iceAmount; } }
        public int SugarAmount { get { return sugarAmount; } }

        public LemonadeRecipe()
        {
            GetRecipe();
        }

        public void GetRecipe()
        {
            GetLemonAmount();
            GetSugarAmount();
            GetIceAmount();
            DisplayRecipe();
        }

        public void GetLemonAmount()
        {
            Console.WriteLine("How many lemons should be in each glass? Enter the amount: ");
            lemonAmount = int.Parse(Console.ReadLine());
        }

        public void GetSugarAmount()
        {
            Console.WriteLine("How many lemons should be in each glass? Enter the amount: ");
            sugarAmount = int.Parse(Console.ReadLine());
        }

        public void GetIceAmount()
        {
            Console.WriteLine("How many lemons should be in each glass? Enter the amount: ");
            iceAmount = int.Parse(Console.ReadLine());
        }
        
        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients per cup of Lemonade: ");
            Console.WriteLine($"Lemons: {lemonAmount}");
            Console.WriteLine($"Sugar: {sugarAmount}");
            Console.WriteLine($"Ice: {iceAmount}");
            Console.WriteLine();
        }
    }
}
