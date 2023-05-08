using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri.Class
{
    public abstract class Shape
    {
        // Properties that can be accessed by classes that inherits this class
        protected double A { get; set; }
        protected double B { get; set; }

        // Constructor to initialize the values of A and B
        public Shape(double a, double b)
        {
            A = a;
            B = b;
        }

        // Abstract methods that must be implemented by the classes that inherits this class
        public abstract double GetCircumference();
        public abstract double GetArea();
    }

}
