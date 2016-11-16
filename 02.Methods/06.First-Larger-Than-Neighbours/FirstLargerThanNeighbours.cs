using System;
using System.Linq;

/// <summary>
/// Write a method that returns the index of the first element in array that 
/// is larger than its neighbours, or -1, if there is no such element.
/// </summary>
class FirstLargerThanNeighbours
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine(FirstLargerThanNeighboursInArray(FromStringToIntArray()));
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
    /// Firsts the larger than neighbours in array.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns></returns>
    static int FirstLargerThanNeighboursInArray(int[] array)
    {
        int firstNeighboursIndex = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                firstNeighboursIndex = i;
                break;
            }
            else
            {
                firstNeighboursIndex = -1;
            }
        }
        return firstNeighboursIndex;
    }
}