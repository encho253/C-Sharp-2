using System;
using System.Linq;

/// <summary>
/// Write a method that counts how many times given number appears in a given array. 
/// Write a test program to check if the method is working correctly.
/// </summary>
class AppearanceCount
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine(HoWManyTimesNumberInArray(size,FromStringToIntArray(), int.Parse(Console.ReadLine())));       
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
    /// Hoes the w many times number in array.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <param name="arrayNumbers">The array numbers.</param>
    /// <param name="number">The number.</param>
    /// <returns></returns>
    static int HoWManyTimesNumberInArray(int size,int[] arrayNumbers,int number)
    {
        int counter = 0;

        for (int i = 0; i < size; i++)
        {
            if (arrayNumbers[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}