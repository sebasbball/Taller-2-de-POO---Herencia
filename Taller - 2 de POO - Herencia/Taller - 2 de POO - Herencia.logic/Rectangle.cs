using System;


namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a rectangle
    /// </summary>
    public class Rectangle : GeometricFigure
    {
        // Private fields for width and height
        private double _a;
        private double _b;

        // Properties with validation
        public double A
        {
            get { return _a; }
            set { _a = ValidateA(value); }
        }

        public double B
        {
            get { return _b; }
            set { _b = ValidateB(value); }
        }

        // Constructor
        public Rectangle(string name, double a, double b)
        {
            Name = name;
            A = a;
            B = b;
        }

        // Validation methods
        private double ValidateA(double a)
        {
            if (a <= 0)
                throw new ArgumentException("Width must be greater than 0");
            return a;
        }

        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("Height must be greater than 0");
            return b;
        }

        // Calculate area using A * B
        public override double GetArea()
        {
            return A * B;
        }

        // Calculate perimeter using 2 * (A + B)
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}
