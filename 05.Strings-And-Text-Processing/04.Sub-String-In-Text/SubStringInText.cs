using System;
using System.Text;

/// <summary>
/// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
/// </summary>
class SubStringInText
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        int counter = SearchPatternInString(text, pattern);
        Console.WriteLine(counter);
    }
    /// <summary>
    /// Searches the pattern in string.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="pattern">The pattern.</param>
    /// <returns></returns>
    static int SearchPatternInString(string text, string pattern)
    {
        int counter = 0;
        int i = 0;

        while ((i = text.IndexOf(pattern, i, StringComparison.CurrentCultureIgnoreCase)) != -1)
        {
            i++;
            counter++;
        }
        return counter;
    }
}