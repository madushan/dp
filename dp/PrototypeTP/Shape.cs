using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeTP
{
    abstract class Shape
    {
        private string id;
        protected string type;

        public abstract void draw();
        
        public string getType()
        {
            return type;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public object clone()
        {
            object clone = null;
            try
            {
                clone = this.MemberwiseClone();
            }
            catch (Exception)
            {
                throw;
            }
            return clone;
        }
    }
}
