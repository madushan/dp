using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class ChickenBurger : Burger
    {
        public override decimal Price()
        {
            return 50;
        }
        public override string Name()
        {
            return "Chicken Burger";
        }
    }
}
