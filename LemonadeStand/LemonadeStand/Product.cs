using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Product
    {
        public string type;
        public double price;
        public int quanity;
        public int shelfLife;

        public Product()
        {
        }
    }
}
