using System;
using System.Linq;

/// <summary>
/// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
/// Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, 
/// average, sum and product.
/// </summary>
class IntegerCalculations
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
        MinMaxAverageSumProduct(inputArray);
    }
    
    /// <summary>
    /// Minimum, maximum, average, sum and product.
    /// </summary>
    /// <param name="array">The array.</param>
    static void MinMaxAverageSumProduct(int[] array)
    {
        long product = 1;

        Console.WriteLine(array.Min());
        Console.WriteLine(array.Max());
        Console.WriteLine("{0:F2}",array.Average());
        Console.WriteLine(array.Sum());

        foreach (var item in array)
        {
            product *= item;
        }
        Console.WriteLine(product);
    }
}