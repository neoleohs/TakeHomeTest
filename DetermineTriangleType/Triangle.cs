using System;

namespace DetermineTriangleType
{
    public abstract class Triangle
    {
        protected int _a;
        protected int _b;
        protected int _c;

        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        protected double Area()
        {
            double s = (_a + _b + _c) / 2;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }
    }
}
