using System;
using System.Collections.Generic;
using Taller___2_de_POO___Herencia.logic;
using Taller___2_de_POO___Herencia.Logic;

namespace Taller___2_de_POO___Herencia.Console
{
    /// <summary>
    /// Main program class to test geometric figures
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create instances of different geometric figures
                var circle = new Circle(nameof(Circle), 5);
                var square = new Square(nameof(Square), 10);
                var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
                var kite = new Kite(nameof(Kite), 8, 7, 5, 6);
                var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790);
                var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 23.09);
                var triangle = new Triangle(nameof(Triangle), 45.56, 12.34, 27.09, 15);
                var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 266.666667);

                // Create a list of all figures
                var figures = new List<GeometricFigure>() { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze };

                // Display information for each figure
                foreach (var figure in figures)
                {
                    System.Console.WriteLine(figure);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }

            // Keep console open
            System.Console.WriteLine("\nPress any key to exit...");
            System.Console.ReadKey();
        }
    }
}