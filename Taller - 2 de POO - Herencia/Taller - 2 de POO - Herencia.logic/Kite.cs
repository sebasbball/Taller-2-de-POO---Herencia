using System;
using System.Drawing;
using Taller___2_de_POO___Herencia.logic;

namespace Taller___2_de_POO___Herencia.Logic
{
    /// <summary>
    /// Class representing a kite, inherits from Rhombus
    /// </summary>
    public class Kite : Rhombus
    {
        // Private field for second side length
        private double _b;

        // Property for second side length
        public double B
        {
            get { return _b; }
            set { _b = ValidateB(value); }
        }

        // Constructor
        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }

        // Validation method
        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("Side B must be greater than 0");
            return b;
        }

        // Area calculation remains the same as rhombus: (D1 * D2) / 2
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        // Override perimeter calculation using 2 * (A + B)
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}