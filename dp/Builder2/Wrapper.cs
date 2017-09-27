using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    public class Wrapper : IPacking
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
