using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Write a method that adds two positive integer numbers represented as arrays of digits 
/// (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
/// Write a program that reads two arrays representing positive integers and outputs their sum.
/// </summary>
class NumberAsArray
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string size = Console.ReadLine();
        int[] sizeArray = size.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        int[] firstArray = InputArrayAsString(size[0]);
        int[] secondArray = InputArrayAsString(size[1]);

        char[] sumAsArray = SumOfTwoArrays(firstArray,secondArray);

        PrintAnswer(sumAsArray);
    }

    /// <summary>
    /// Inputs the array as string.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns></returns>
    static int[] InputArrayAsString(int size)
    {
        string arrayAsString = Console.ReadLine();
        int[] intArray = new int[size];

        intArray = arrayAsString.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

        return intArray;
    }

    /// <summary>
    /// Sums the of two arrays.
    /// </summary>
    /// <param name="firstArray">The first array.</param>
    /// <param name="secondArray">The second array.</param>
    /// <returns></returns>
    static char[] SumOfTwoArrays(int[] firstArray,int[] secondArray)
    {
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        int numberFromFirstArray = int.Parse(string.Join("", firstArray));
        int numberFromSecondArray = int.Parse(string.Join("", secondArray));
        int sum = numberFromFirstArray + numberFromSecondArray;
        string sumAsString = sum.ToString();
        char[] sumAsArray = sumAsString.ToCharArray();
        Array.Reverse(sumAsArray);
        return sumAsArray;
    }

    /// <summary>
    /// Prints the answer.
    /// </summary>
    /// <param name="sumAsArray">The sum as array.</param>
    static void PrintAnswer(char[] sumAsArray)
    {
        foreach (var item in sumAsArray)
        {
            Console.Write(item + " ");
        }
    }
}