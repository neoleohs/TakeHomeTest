using System;
using System.Linq;
using DetermineTriangleType.Triangles;

namespace DetermineTriangleType
{
    /// <summary>
    /// Question 1.1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[3] { 0, 0, 0 };

            if (args.Length < 3)
            {
                Console.WriteLine("Please enter 3 numbers.");
                return;
            }

            int.TryParse(args[0], out values[0]);
            int.TryParse(args[1], out values[1]);
            int.TryParse(args[2], out values[2]);

            if (values.Where(n => n <= 0).Count() > 0)
            {
                Console.WriteLine("Please enter positive numbers.");
                return;
            }

            ITriangle triagle = DetermineType(values);

            Console.WriteLine(string.Format("It is {0}!!!", triagle.Type().ToString()));
            Console.WriteLine(string.Format("Area = {0}", triagle.GetArea()));
        }

        private static ITriangle DetermineType(int[] values)
        {
            if (values.Distinct().Count() == 3)
                return new Scalene(values[0], values[1], values[2]);

            if (values.Distinct().Count() == 2)
                return new Isosceles(values[0], values[1], values[2]);

            if (values.Distinct().Count() == 1)
                return new Equilateral(values[0], values[1], values[2]);

            throw new Exception("Unknown type.");
        }
    }
}
