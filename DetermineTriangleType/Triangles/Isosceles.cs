using System.Linq;

namespace DetermineTriangleType.Triangles
{
    public class Isosceles : Triangle, ITriangle
    {
        public Isosceles(int a, int b, int c)
            : base(a, b, c)
        {}

        public TriangleType Type()
        {
            return TriangleType.Isosceles;
        }

        public double GetArea()
        {
            return base.Area();
        }
    }
}
