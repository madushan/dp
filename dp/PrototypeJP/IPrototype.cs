using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeJP
{
    interface IPrototype
    {
        IPrototype getClone();
    }
}
