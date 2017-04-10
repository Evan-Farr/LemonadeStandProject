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

        public double Price { get { return price; } set { price = value; } }

        public Product()
        {
        }
    }
}
