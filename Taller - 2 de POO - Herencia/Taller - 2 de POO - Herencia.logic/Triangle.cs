using System;
using System.Xml.Linq;
using Taller___2_de_POO___Herencia.logic;

namespace Taller___2_de_POO___Herencia.Logic
{
    /// <summary>
    /// Class representing a triangle
    /// </summary>
    public class Triangle : GeometricFigure
    {
        // Private fields for base, height and sides
        private double _a;
        private double _b;
        private double _c;
        private double _h;

        // Properties with validation
        public double A
        {
            get { return _a; }
            set { _a = ValidateSide(value); }
        }

        public double B
        {
            get { return _b; }
            set { _b = ValidateSide(value); }
        }

        public double C
        {
            get { return _c; }
            set { _c = ValidateSide(value); }
        }

        public double H
        {
            get { return _h; }
            set { _h = ValidateSide(value); }
        }

        // Constructor
        public Triangle(string name, double a, double b, double c, double h)
        {
            Name = name;
            A = a;
            B = b;
            C = c;
            H = h;
        }

        // Validation method
        private double ValidateSide(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Value must be greater than 0");
            return value;
        }

        // Calculate area using (B * H) / 2
        public override double GetArea()
        {
            return (B * H) / 2;
        }

        // Calculate perimeter using A + B + C
        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}