using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Class
{
    public class Trapezoid: Shape
    {
        private double c;
        private double d;

        // Constructor to initialize the values of A, B, C, and D
        public Trapezoid(double a, double b, double c, double d) : base(a, b)
        {
            this.c = c;
            this.d = d;
        }

        // Method to calculate the circumference of the trapezoid
        public override double GetCircumference()
        {
            return A + B + c + d;
        }
        // Method to calculate the area of the trapezoid
        public override double GetArea()
        {
            double s = (A + B - c + d) / 2;
            double h = 2 / (A - c) * Math.Sqrt(s * (s - A + c) * (s - B) * (s - d));
            return (A + c) * h / 2;
        }
    }
}
