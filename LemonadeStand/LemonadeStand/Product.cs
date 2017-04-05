using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Product
    {
        protected double price;
        protected int shelfLife;

        public Product()
        {
        }

        public void Spoil()
        {
            shelfLife -= 1;
        }

        public double Price { get { return shelfLife; } set { price = value; } }

        public int ShelfLife { get { return shelfLife; } set { shelfLife = value; } }
    }
}
