using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeStructural
{
    class ConcretePrototype2:Prototype
    {
        public ConcretePrototype2(string id):base(id)
        {
            
        }
        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }
    }
}
