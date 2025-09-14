
namespace Taller___2_de_POO___Herencia.logic
{
    /// <summary>
    /// Abstract base class for geometric figures
    /// </summary>

    public abstract class GeometricFigure
    {
        // Property to store the same of the figure
        public string Name { get; set; }

        // Abstract methods that must be implemented by derived classes
        public abstract double GetArea();
        public abstract double GetPerimeter();

        // Override ToString to display figure information
        public override string ToString()
        {
            return $"{Name} => Area .....: {GetArea() :F5} Perimeter: {GetPerimeter() :F5}";
        }
    }

}
