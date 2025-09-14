using System;
using Taller___2_de_POO___Herencia.logic;

namespace Taller___2_de_POO___Herencia.Logic
{
    /// <summary>
    /// Class representing a triangle, inherits from Rectangle
    /// </summary>
    public class Triangle : Rectangle
    {
        // Private field for side C and height
        private double _c;
        private double _h;

        // Property with validation
        public double C
        {
            get { return _c; }
            set { _c = ValidateC(value); }
        }

        public double H
        {
            get { return _h; }
            set { _h = ValidateH(value); }
        }

        // Constructor
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        // Validation method
        private double ValidateC(double c)
        {
            if (c <= 0)
                throw new ArgumentException("Side C must be greater than 0");
            return c;
        }

        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("Height must be greater than 0");
            return h;
        }

        // Override area calculation using (B * H) / 2
        public override double GetArea()
        {
            return (B * H) / 2;
        }

        // Override perimeter calculation using A + B + C
        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}