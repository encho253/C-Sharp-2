using System;

/// <summary>
/// Write a method that reverses the digits of a given decimal number.
/// </summary>
class ReverseNumber
{

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(ReverseDecimalNumber(number));
    }

    /// <summary>
    /// Reverses the decimal number.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns></returns>
    static string ReverseDecimalNumber(string number)
    {     
        char[] arr = number.ToCharArray();
        Array.Reverse(arr);
        string numberToString = new string(arr);
   
        return numberToString;
    }
}