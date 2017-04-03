using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice : Product
    {
        public Ice(double Price, int Quanity)
        {
            type = "ice";
            price = Price;
            quanity = Quanity;
        }
    }
}
