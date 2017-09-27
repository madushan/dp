using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeTP
{
    class Square:Shape
    {
        public Square()
        {
            type = "Square";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Square::draw()");
        }
    }
}
