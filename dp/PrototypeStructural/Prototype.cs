using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeStructural
{
    abstract class Prototype
    {
        private string _id;
        public Prototype(string id)
        {
            this._id = id;
        }
        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}
