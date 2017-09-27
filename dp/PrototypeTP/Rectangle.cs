using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeTP
{
    class Rectangle:Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::draw");
        }
    }
}
