using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice : Product
    {
        public Ice()
        {
            type = "cube of ice";
            price = .25;
            shelfLife = 1;
        }
    }
}
