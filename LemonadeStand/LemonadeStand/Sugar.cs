using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar : Product
    {
        public Sugar(double Price, int Quanity)
        {
            type = "sugar";
            price = Price;
            quanity = Quanity;
        }
    }
}
