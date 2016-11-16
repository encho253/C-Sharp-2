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
        PrintSumOfTheArrays(SumOfTwoArrays(InputArrayAsString(sizeArray[0]), InputArrayAsString(sizeArray[1])));      
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
    /// Sums of two arrays.
    /// </summary>
    /// <param name="firstArray">The first array.</param>
    /// <param name="secondArray">The second array.</param>
    /// <returns></returns>
    static List<int> SumOfTwoArrays(int[] firstArray,int[] secondArray)
    {
        List<int> sumOfTwoArrays = new List<int>();
        int sum = 0;
        int keepInMind = 0;

        KeyValuePair<int[],int[]> pair = WhoIsTheSmallestArray(firstArray,secondArray);
        int[] smallestArray = pair.Value;
        int[] bigestArray = pair.Key;

        for (int i = 0; i < bigestArray.Length ; i++)
        {
            if (i < smallestArray.Length)
            {
                if (smallestArray[i] + bigestArray[i] + keepInMind > 9)
                {
                    sum = (smallestArray[i] + bigestArray[i] + keepInMind) % 10;
                    sumOfTwoArrays.Add(sum);
                    keepInMind = 1;
                }
                else
                {
                    sum = smallestArray[i] + bigestArray[i] + keepInMind;
                    sumOfTwoArrays.Add(sum);
                    keepInMind = 0;
                }
            }
            else
            {
                sum = bigestArray[i] + keepInMind + 0;               
                if (sum > 9)
                {
                    sum %= 10;
                    keepInMind = 1;
                }
                else
                {
                    keepInMind = 0;
                }
                sumOfTwoArrays.Add(sum);
            }
        }
        return sumOfTwoArrays;          
    }

    /// <summary>
    /// Whoes is the smallest array.
    /// </summary>
    /// <param name="firstArray">The first array.</param>
    /// <param name="secondArray">The second array.</param>
    /// <returns></returns>
    static KeyValuePair<int[], int[]> WhoIsTheSmallestArray(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length > secondArray.Length)
        {
            return new KeyValuePair<int[], int[]>(firstArray,secondArray);
        }
        else if (firstArray.Length < secondArray.Length)
        {
            return new KeyValuePair<int[], int[]>(secondArray, firstArray);
        }
        else
        {
            return new KeyValuePair<int[], int[]>(secondArray, firstArray);
        }
    }
    /// <summary>
    /// Prints the sum of the arrays.
    /// </summary>
    /// <param name="sumOfTwoArrays">The sum of two arrays.</param>
    static void PrintSumOfTheArrays(List<int> sumOfTwoArrays)
    {
        foreach (var item in sumOfTwoArrays)
        {
            Console.Write(item + " ");
        }
    }
}