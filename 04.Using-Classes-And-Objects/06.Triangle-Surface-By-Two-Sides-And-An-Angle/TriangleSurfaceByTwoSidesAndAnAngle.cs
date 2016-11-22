using System;

/// <summary>
/// Write program that calculates the surface of a triangle by given two sides and an angle between them.
/// </summary>
class TriangleSurfaceByTwoSidesAndAnAngle
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
    
        double surface = Tringle.SurfaceByTwoSidesAndAngle(a, b, c);
        Console.WriteLine("{0:F2}", surface);
    }
    /// <summary>
    /// 
    /// </summary>
    static class Tringle
    {
        /// <summary>
        /// Surfaces the by two sides and angle.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns></returns>
        public static double SurfaceByTwoSidesAndAngle(double a, double b, double c)
        {
            c = (Math.PI / 180) * c; //The maths to convert an angle from degrees to radians
            double surface = (a * b * Math.Sin(c))/2;
            return surface;
        }
    }
}