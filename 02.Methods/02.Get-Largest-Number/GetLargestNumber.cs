using System;
using System.Linq;

/// <summary>
/// Write a method GetMax() with two parameters that returns the larger of two integers. 
/// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
/// </summary>
class GetLargestNumber
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {      
        GetMax(ReadNumbers());
    }

    /// <summary>
    /// Reads the numbers.
    /// </summary>
    /// <returns></returns>
    static string ReadNumbers()
    {
        string numbers = Console.ReadLine();
        return numbers;
    }

    /// <summary>
    /// Gets the maximum.
    /// </summary>
    /// <param name="inputNumbers">The input numbers.</param>
    static void GetMax(string inputNumbers)
    {
        int[] arrayNumbers = inputNumbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        Console.WriteLine(arrayNumbers.Max());      
    }
}