using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cup : Product
    {
        public Cup()
        {
            type = "cup(s)";
            price = 2;
            shelfLife = 100;
        }
    }
}
