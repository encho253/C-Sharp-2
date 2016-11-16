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
        int[] array = InputData();
        MinMaxAverageSumProduct(array);
    }
    /// <summary>
    /// Inputs the data.
    /// </summary>
    /// <returns></returns>
    static int[] InputData()
    {
        int[] array = new int[5];

        string arrayAsString = Console.ReadLine();
        array = arrayAsString.Split().Select(n => Convert.ToInt32(n)).ToArray();

        return array;
    }

    /// <summary>
    /// Minimum, maximum, average, sum and product.
    /// </summary>
    /// <param name="array">The array.</param>
    static void MinMaxAverageSumProduct(int[] array)
    {
        int product = 0;

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