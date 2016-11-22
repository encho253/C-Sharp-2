using System;
using System.Linq;

/// <summary>
/// You are given a sequence of positive integer values written into a string, separated by spaces.
/// Write a function that reads these values from given string and calculates their sum. Write a program 
/// that reads a string of positive integers separated by spaces and prints their sum.
/// </summary>
class SumInteger
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] splitNumbers = StringFunction.SplitBySpace(numbers);
        int sum = StringFunction.Sum(splitNumbers);
        Console.WriteLine(sum);
    }
}
/// <summary>
/// 
/// </summary>
static class StringFunction
{
    /// <summary>
    /// Splits the by space.
    /// </summary>
    /// <param name="numbers">The numbers.</param>
    /// <returns></returns>
    public static int[] SplitBySpace(string numbers)
    {
        int[] splitNumbers = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        return splitNumbers;
    }
    /// <summary>
    /// Sums the specified numbers.
    /// </summary>
    /// <param name="numbers">The numbers.</param>
    /// <returns></returns>
    public static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        return sum;
    }
}