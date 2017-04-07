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

        public double Price { get { return price; } set { price = value; } }
        public int ShelfLife { get { return shelfLife; } set { shelfLife = value; } }

        public Product()
        {
        }

        public virtual void Spoil()
        {
            shelfLife -= 1;
        }
    }
}
