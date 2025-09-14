using System;


namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a rectangle, inherits from Square
    /// </summary>
    public class Rectangle : Square
    {
        // Private field for second side
        private double _b;

        // Property for second side with validation
        public double B
        {
            get { return _b; }
            set { _b = ValidateB(value); }
        }

        // Constructor
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        // Validation method
        private double ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("Side B must be greater that 0");
            return b;
        }

        // Override area calculation using A * B
        public override double GetArea()
        {
            return A * B;
        }

        // Override perimeter calculation using 2 * (A + B)
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}
