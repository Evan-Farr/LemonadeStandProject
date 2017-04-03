using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon : Product
    {
        public Lemon(double Price, int Quanity)
        {
            type = "lemon(s)";
            price = Price;
            quanity = Quanity;
        }
    }
}
