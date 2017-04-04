using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar : Product
    {
        public Sugar()
        {
            type = "sugar cube";
            price = .75;
            shelfLife = 5;
        }
    }
}
