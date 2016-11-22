using System;

/// <summary>
/// 
/// </summary>
class TriangleSurfaceBySideAndAltitude
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double lenght = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", TriangleSurface.SurfaceCalculate(lenght, altitude));
    }
}

/// <summary>
/// 
/// </summary>
static class TriangleSurface
{
    /// <summary>
    /// Surfaces the calculate.
    /// </summary>
    /// <param name="lenght">The lenght.</param>
    /// <param name="altitude">The altitude.</param>
    /// <returns></returns>
    public static double SurfaceCalculate(double lenght, double altitude)
    {
        double finalResult = (lenght * altitude) / 2;
        return finalResult;
    }
}