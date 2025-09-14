using System;
using System.Xml.Linq;
using Taller___2_de_POO___Herencia.logic;

namespace Taller___2_de_POO___Herencia.Logic
{
    /// <summary>
    /// Class representing a trapeze
    /// </summary>
    public class Trapeze : GeometricFigure
    {
        // Private fields for the trapeze dimensions
        private double _a;
        private double _b;
        private double _c;
        private double _d;
        private double _h;

        // Properties with validation
        public double A
        {
            get { return _a; }
            set { _a = ValidateValue(value); }
        }

        public double B
        {
            get { return _b; }
            set { _b = ValidateValue(value); }
        }

        public double C
        {
            get { return _c; }
            set { _c = ValidateValue(value); }
        }

        public double D
        {
            get { return _d; }
            set { _d = ValidateValue(value); }
        }

        public double H
        {
            get { return _h; }
            set { _h = ValidateValue(value); }
        }

        // Constructor
        public Trapeze(string name, double a, double b, double c, double d, double h)
        {
            Name = name;
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
        }

        // Validation method
        private double ValidateValue(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Value must be greater than 0");
            return value;
        }

        // Calculate area using (B + D) * H / 2
        public override double GetArea()
        {
            return (B + D) * H / 2;
        }

        // Calculate perimeter using A + B + C + D
        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
    }
}