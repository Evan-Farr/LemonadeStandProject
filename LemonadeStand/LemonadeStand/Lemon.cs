using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemon : Product
    {
        public Lemon()
        {
            type = "lemon(s)";
            price = 1.50;
            shelfLife = 3;
        }
    }
}
