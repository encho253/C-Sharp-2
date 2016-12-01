using System;
using System.Text;

/// <summary>
/// Write a program that reads from the console a string of maximum 20 characters. 
/// If the length of the string is less than 20, the rest of the characters should be filled with *.
/// </summary>
class StringLength
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string text = Console.ReadLine();
        string newText = AddCharactersToString(text);
        Console.WriteLine(newText);
    }
    /// <summary>
    /// Adds the characters to string.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    static string AddCharactersToString(string text)
    {
        if (text.Length < 20)
        {
            StringBuilder builder = new StringBuilder();
            int size = 20 - text.Length;
            builder.Append(text);

            for (int i = 0; i < size; i++)
            {
               builder.Append("*");
            }
            text = builder.ToString();
        }
        return text;
    }
}