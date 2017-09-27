using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class Coke : ColdDrink
    {
        public override decimal Price()
        {
            return 30;
        }
        public override string Name()
        {
            return "Coke";
        }
    }
}
