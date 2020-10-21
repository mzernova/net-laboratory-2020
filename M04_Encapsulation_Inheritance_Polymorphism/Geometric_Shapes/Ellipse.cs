using System;

namespace Geometric_Shapes
{
    class Ellipse : IShape
    {
        private double majorRadius;
        private double minorRadius;

        public Ellipse(double majorRadius, double minorRadius)
        {
            this.majorRadius = majorRadius;
            this.minorRadius = minorRadius;
        }

        public double MajorRadius { get => majorRadius; }
        public double MinorRadius { get => minorRadius; }

        public double Area()
        {
            return Math.PI * minorRadius * majorRadius; 
        }

        public double Perimeter()
        {
            return 4.0 * (Area() + Math.Pow (MajorRadius - MinorRadius, 2)) / (MajorRadius + MinorRadius); 
        }
    }
}
