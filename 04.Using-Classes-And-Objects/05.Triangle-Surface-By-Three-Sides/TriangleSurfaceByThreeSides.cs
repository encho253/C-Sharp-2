using System;

/// <summary>
/// Write program that calculates the surface of a triangle by given its three sides.
/// </summary>
class TriangleSurfaceByThreeSides
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double surface = Tringle.SurfaceByThreeSides(a,b,c);
        Console.WriteLine("{0:F2}",surface);
    }
}
/// <summary>
/// 
/// </summary>
static class Tringle
{
    /// <summary>
    /// Surfaces the by three sides.
    /// </summary>
    /// <param name="a">a.</param>
    /// <param name="b">The b.</param>
    /// <param name="c">The c.</param>
    /// <returns></returns>
    public static double SurfaceByThreeSides(double a,double b, double c)
    {
        double semip = (a + b + c) / 2;
        double surface = Math.Sqrt(semip * (semip - a) * (semip - b) * (semip - c));
        return surface;
    } 
}