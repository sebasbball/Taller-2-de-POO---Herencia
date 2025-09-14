
using System;

namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a circle
    /// </summary>
    public class Circle : GeometricFigure
    {
        // Private field for radius
        private double _r;

        // Property for radius with validation
        public double R
        {
            get { return _r; }
            set { _r = ValidateR(value); }
        }

        // Constructor
        public Circle(string name, double r)
        {
            Name = name;
            R = r;
        }

        // Method to validate radius
        private double ValidateR(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Radius must be greater that 0");
            return r;
        }

        // Calculate area using π * r²
        public override Double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        // Calculate perimeter using 2 * π * r
        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
    }
}