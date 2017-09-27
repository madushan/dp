using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class VegBurger : Burger
    {
        public override decimal Price()
        {
            return 25;
        }
        public override string Name()
        {
            return "Veg Burger";
        }
    }
}
