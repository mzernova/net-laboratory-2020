using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shapes
{
    class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle (double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get => width; }
        public double Height { get => height; }

        public double Area()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return (width + height) * 2.0;
        }
    }
}
