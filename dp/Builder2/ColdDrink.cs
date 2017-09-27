using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public abstract class ColdDrink : IItem
    {
        public IPacking Packing()
        {
            return new Bottle();
        }
        public abstract string Name();
        public abstract decimal Price();
    }
}
