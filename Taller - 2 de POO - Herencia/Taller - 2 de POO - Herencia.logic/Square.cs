using System;


namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Class representing a square, inherits from Rectangle
    /// </summary>
    public class Square : Rectangle
    {
        // Property for side length
        public double Side
        {
            get { return A; }
            set { A = B = ValidateA(value); }
        }

        // Constructor
        public Square(string name, double side) : base(name, side, side)
        {}

        // Validation method
        private double ValidateA(double side)
        {
            if (side <= 0)
                throw new ArgumentOutOfRangeException("Side must be grater than 0");
            return side;
        }
    }
}
