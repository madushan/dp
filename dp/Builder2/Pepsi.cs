using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class Pepsi : ColdDrink
    {
        public override decimal Price()
        {
            return 35;
        }
        public override string Name()
        {
            return "Pepsi";
        }
    }
}
