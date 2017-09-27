using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeTP
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.loadCache();

            Shape clonedShape1 = (Shape)ShapeCache.getShape("1");
            Console.WriteLine("Shape : "+ clonedShape1.getType());

            Shape clonedShape2 = (Shape) ShapeCache.getShape("2");
            Console.WriteLine("Shape : "+clonedShape2.getType());

            Shape clonedShape3 = (Shape) ShapeCache.getShape("3");
            Console.WriteLine("Shape : "+clonedShape3.getType());

            Console.ReadKey();
        }
    }
}
