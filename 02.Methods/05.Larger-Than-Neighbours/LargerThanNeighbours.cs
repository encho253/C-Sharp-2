using System;
using System.Linq;

/// <summary>
/// Write a method that checks if the element at given position in given array of integers 
/// is larger than its two neighbours (when such exist). Write program that reads an array of numbers 
/// and prints how many of them are larger than their neighbours.
/// </summary>
class LargerThanNeighbours
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine(LargerThanNeighboursInArray(FromStringToIntArray()));
    }
    /// <summary>
    /// Froms the string to int array.
    /// </summary>
    /// <returns></returns>
    static int[] FromStringToIntArray()
    {
        string elementsInArray = Console.ReadLine();
        int[] arrayString = elementsInArray.Split().Select(n => Convert.ToInt32(n)).ToArray();
        return arrayString;
    }

    /// <summary>
    /// Largers the than neighbours in array.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns></returns>
    static int LargerThanNeighboursInArray(int[] array)
    {
        int counter = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {         
            if (array[i] > array[i - 1] && array[i] > array [i + 1])
            {
                counter++;
            }
        }
        return counter;
    }
}