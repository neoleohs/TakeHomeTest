using System.Linq;

namespace DetermineTriangleType.Triangles
{
    public class Scalene : Triangle, ITriangle
    {
        public Scalene(int a, int b, int c)
            : base(a, b, c)
        {}

        public TriangleType Type()
        {
            return TriangleType.Scalene;
        }

        public double GetArea()
        {
            return base.Area();
        }
    }
}
