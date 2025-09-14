using System;
using Taller___2_de_POO___Herencia.logic;

namespace Taller___2_de_POO___Herencia.Logic
{
    /// <summary>
    /// Class representing a trapeze, inherits from Triangle
    /// </summary>
    public class Trapeze : Triangle
    {
        // Private field for side D
        private double _d;

        // Property for side D with validation
        public double D
        {
            get { return _d; }
            set { _d = ValidateD(value); }
        }

        // Constructor
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        // Validation method
        private double ValidateD(double d)
        {
            if (d <= 0)
                throw new ArgumentException("Side D must be greater than 0");
            return d;
        }

        // Override area calculation using (B + D) * H / 2
        public override double GetArea()
        {
            return (B + D) * H / 2;
        }

        // Override perimeter calculation using A + B + C + D
        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
    }
}