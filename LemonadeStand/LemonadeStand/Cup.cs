using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cup : Product
    {
        public Cup(double Price)
        {
            type = "cup(s)";
            price = Price;
            shelfLife = 100;
        }
    }
}
