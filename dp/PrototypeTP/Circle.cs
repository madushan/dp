using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeTP
{
    class Circle:Shape
    {
        public Circle()
        {
            type = "Circle";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Circle::draw()");
        }
    }
}
