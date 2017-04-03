using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cup : Product
    {
        public Cup(double Price, int Quanity)
        {
            type = "cup(s)";
            price = Price;
            quanity = Quanity;
        }
    }
}
