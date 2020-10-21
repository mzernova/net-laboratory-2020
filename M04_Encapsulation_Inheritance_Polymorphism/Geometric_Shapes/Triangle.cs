using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Shapes
{
    class Triangle : IShape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle (double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double SideA { get => sideA; }
        public double SideB { get => sideB; }
        public double SideC { get => sideC; }

        public double Area()
        {
            double p = Perimeter() * 0.5;
            return Math.Sqrt (p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public double Perimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
