using System;

/// <summary>
/// Write a program that reads a string, reverses it and prints the result on the console.
/// </summary>
class ReverseString
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string text = Console.ReadLine();
        string reverseString = StringReverse(text);
        Console.WriteLine(reverseString);
    }
    /// <summary>
    /// Strings the reverse.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    static string StringReverse(string text)
    {
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}