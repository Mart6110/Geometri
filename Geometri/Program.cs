using Geometri.Class;
using System;
using System.Collections.Generic;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold all the shapes
            List<Shape> shapes = new List<Shape>();

            // Create instances of each shape and add them to the list
            Square square = new Square(5);
            shapes.Add(square);

            Rectangle rectangle = new Rectangle(5, 17);
            shapes.Add(rectangle);

            Parallelogram parallelogram = new Parallelogram(12, 9, 35);
            shapes.Add(parallelogram);

            Trapezoid trapezoid = new Trapezoid(14, 6, 8, 6);
            shapes.Add(trapezoid);

            Triangle triangle = new Triangle(14, 6);
            shapes.Add(triangle);

            // Loop through the list and call the methods for each shape
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name); // Print the name of the shape
                Console.WriteLine("Circumference: " + shape.GetCircumference()); // Calculate and print the circumference
                Console.WriteLine("Area: " + shape.GetArea()); // Calculate and print the area
                Console.WriteLine();
            }
        }
    }
}
