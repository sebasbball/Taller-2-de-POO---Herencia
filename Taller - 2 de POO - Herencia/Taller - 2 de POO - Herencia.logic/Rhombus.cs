using System;


namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a rhombus, inherits from Square
    /// </summary>
    public class Rhombus : Square
    {
        // Private fields for diagonals
        private double _d1;
        private double _d2;

        // Properties for diagonals
        public double D1
        {
            get { return _d1; }
            set { _d2 = ValidateD1(value); }
        }

        public double D2
        {
            get { return _d2; }
            set { _d1 = ValidateD2(value);  }
        }

        // Constructor
        public Rhombus(string name, double side, double d1, double d2) : base(name, side)
        {

            D1 = d1;
            D2 = d2;
        }

        // Validation methods
        private double ValidateD1(double d1)
        {
            if (d1 <= 0)
                throw new ArgumentException("Diagonal 1 must be a greater than 0");
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 <= 0)
                throw new ArgumentException("Diagonal 2 must be greater that 0");
            return d2;
        }

        // Override area calculation using (D1 * D2) / 2
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        // Perimeter calculation remains the same as square (4 * side)
    }
}
