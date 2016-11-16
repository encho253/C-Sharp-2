using System;
using System.Linq;

/// <summary>
/// Write a method that returns the maximal element in a portion of array of integers starting at given index. 
/// Using it write another method that sorts an array in ascending / descending order. Write a program that sorts 
/// a given array.
/// </summary>
class SortingArray
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int[] array = InputData();

        int[] sortArray = SortArray(array);

        PrintAnswer(sortArray);
    }

    /// <summary>
    /// Inputs the data.
    /// </summary>
    /// <returns></returns>
    static int[] InputData()
    {
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        string arrayAsString = Console.ReadLine();
        array = arrayAsString.Split().Select(n => Convert.ToInt32(n)).ToArray();

        return array;
    }

    /// <summary>
    /// Sort the array.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns></returns>
    static int[] SortArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    /// <summary>
    /// Print the answer.
    /// </summary>
    /// <param name="sortArray">The sort array.</param>
    static void PrintAnswer(int[] sortArray)
    {
        foreach (var item in sortArray)
        {
            Console.Write(item + " ");
        }
    }
}