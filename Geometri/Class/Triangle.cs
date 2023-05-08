using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Class
{
    class Triangle : Shape
    {
        // Constructor to initialize the values of A and B
        public Triangle(double a, double b) : base(a, b)
        {
        }

        // Method to calculate the circumference of the right triangle
        public override double GetCircumference()
        {
            return A + B + Math.Sqrt(A * A + B * B);
        }

        // Method to calculate the area of the right triangle
        public override double GetArea()
        {
            return A * B / 2;
        }
    }

}
