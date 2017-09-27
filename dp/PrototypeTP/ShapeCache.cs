using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeTP
{
    class ShapeCache
    {
        private static Dictionary<string,Shape> shapeMap = new Dictionary<string, Shape>(); 

        public static Shape getShape(string shapeId)
        {
            Shape cacheShape = shapeMap[shapeId];
            return (Shape)cacheShape.clone();
        }

        public static void loadCache()
        {
            Circle circle = new Circle();
            circle.setId("2");
            shapeMap.Add(circle.getId(),circle);

            Square square = new Square();
            square.setId("1");
            shapeMap.Add(square.getId(),square);

            Rectangle rectangle = new Rectangle();
            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(),rectangle);
        }
    }
}
