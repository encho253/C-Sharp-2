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
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(ReverseDecimalNumber(number));
    }

    /// <summary>
    /// Reverses the decimal number.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns></returns>
    static double ReverseDecimalNumber(double number)
    {
        string numberToString = number.ToString();
        char[] arr = numberToString.ToCharArray();
        Array.Reverse(arr);
        numberToString = new string(arr);
        number = Convert.ToDouble(numberToString);
        return number;
    }
}