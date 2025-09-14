using System.Xml.Linq;
using Taller___2_de_POO___Herencia.logic;

namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a Parallelogram
    /// </summary>
    public class Parallelogram : GeometricFigure
    {
        // Private fields for base and height
        private double _a;
        private double _b;
        private double _h;

        // Properties with validation
        public double A
        {
            get { return _a; }
            set { _a = ValidateH(value); }
        }

        public double B
        {
            get { return _b; }
            set { _b = ValidateH(value); }
        }

        public double H
        {
            get { return _h; }
            set { _h = ValidateH(value); }
}

        // Constructor
        public Parallelogram(string name, double a, double b, double h)
        {
            Name = name;
            A = a;
            B = b;
            H = h;
        }

        // Validation method
        private double ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Value must be greater than 0");
            return value;
        }

        // Calculate area using B * H
        public override double GetArea()
        {
            return B * H;
        }

        // Calculate perimeter using 2 * (A + B)
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}
