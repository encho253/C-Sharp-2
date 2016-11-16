using System;

/// <summary>
/// Write a method that multiplies a number represented as an array of digits by a given integer number. 
/// Write a program to calculate N!.
/// </summary>
class NFactorial
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        CalculateNumberFacturial(number);
    }

    /// <summary>
    /// Calculates the number facturial.
    /// </summary>
    /// <param name="number">The number.</param>
    static void CalculateNumberFacturial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}