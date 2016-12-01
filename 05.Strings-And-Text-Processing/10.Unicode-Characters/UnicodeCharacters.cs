using System;
using System.Text;

/// <summary>
/// Write a program that converts a string to a sequence of C# Unicode character literals.
/// </summary>
class UnicodeCharacters
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string text = Console.ReadLine();
        char[] array = text.ToCharArray();
        string unicode = ConvertTextInUniCode(array);
        Console.WriteLine(unicode);
    }

    /// <summary>
    /// Converts the text in uni code.
    /// </summary>
    /// <param name="array">The array.</param>
    /// <returns></returns>
    static string ConvertTextInUniCode(char[] array)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {

            builder.Append("\\u" + ((int)array[i]).ToString("X4"));
        }

        return builder.ToString();
    }
}