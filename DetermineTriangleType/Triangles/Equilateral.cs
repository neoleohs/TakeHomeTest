using System.Linq;
using System;

namespace DetermineTriangleType.Triangles
{
    public class Equilateral : Triangle, ITriangle
    {
        public Equilateral(int a, int b, int c)
            : base(a, b, c)
        {}

        public TriangleType Type()
        {
            return TriangleType.Equilateral;
        }

        public double GetArea()
        {
            return Math.Sqrt(3d) / 4 * (_a * _a);
        }
    }
}

