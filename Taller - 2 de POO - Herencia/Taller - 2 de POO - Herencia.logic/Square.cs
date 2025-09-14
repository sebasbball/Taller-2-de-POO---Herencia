using System;


namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a square, inherits from GeometricFigure
    /// </summary>
    public class Square : GeometricFigure
    {
        // Property for side length
        private double _a;

        // Propery for side length
        public double A
        {
            get { return _a; }
            set { _a = ValidateA(value); }
        }

        // Constructor
        public Square(string name, double a)
        {
            Name = name;
            A = a;
        }

        // Validation method
        private double ValidateA(double a)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException("Side must be grater than 0");
            return a;
        }

        // Calculate area using A * A
        public override double GetArea()
        {
            return A * A;
        }

        // Calculate perimeter using 4 * A
        public override double GetPerimeter()
        {
            return 4 * A;
        }
    }
}
