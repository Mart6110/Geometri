using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Class
{
    public class Square : Shape
    {
        // Constructor to initialize the value of A and B (since a square has equal sides)
        public Square(double a) : base(a, a)
        {
        }

        // Method to calculate the circumference of the square
        public override double GetCircumference()
        {
            return 4 * A;
        }

        // Method to calculate the area of the square
        public override double GetArea()
        {
            return A * A;
        }
    }
}
