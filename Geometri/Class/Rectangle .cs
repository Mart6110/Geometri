using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Class
{
    public class Rectangle : Shape
    {
        // Constructor to initialize the values of A and B
        public Rectangle(double a, double b) : base(a, b)
        {
        }

        // Method to calculate the circumference of the rectangle
        public override double GetCircumference()
        {
            return 2 * (A + B);
        }

        // Method to calculate the area of the rectangle
        public override double GetArea()
        {
            return A * B;
        }
    }
}
