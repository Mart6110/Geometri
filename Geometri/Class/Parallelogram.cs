using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Class
{
    class Parallelogram: Shape
    {
        private double angle;

        // Constructor to initialize the values of A, B, and the angle between them
        public Parallelogram(double a, double b, double angle) : base(a, b)
        {
            this.angle = angle;
        }

        // Method to calculate the circumference of the parallelogram
        public override double GetCircumference()
        {
            return 2 * (A + B);
        }

        // Method to calculate the area of the parallelogram
        public override double GetArea()
        {
            return A * B * Math.Sin(angle);
        }
    }
}
