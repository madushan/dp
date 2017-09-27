using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public abstract class Burger : IItem
    {
        public IPacking Packing()
        {
            return new Wrapper();
        }
        public abstract string Name();
        public abstract decimal Price();
    }
}
