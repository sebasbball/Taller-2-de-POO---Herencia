using System;

namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a Parallelogram, inherits from Rectangle
    /// </summary>
    public class Parallelogram : Rectangle
    {
        // Private field for height
        private double _h;

        // Property for height with validation
        public double H
        {
            get { return _h; }
            set { _h = ValidateH(value); }
        }

        // Constructor
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        // Validation method
        private double ValidateH(double h)
        {
            if (h <= 0)
                throw new ArgumentException("Height must be greater than 0");
            return h;
        }

        // Override area calculation using B * H
        public override double GetArea()
        {
            return B * H;
        }

        // Override perimeter calculation using 2 * (A + B)
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}