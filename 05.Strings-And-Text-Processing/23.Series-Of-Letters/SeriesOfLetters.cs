using System;
using System.Text;

/// <summary>
/// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
/// </summary>
class SeriesOfLetters
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string text = Console.ReadLine();
        string outPut = RemoveIdenticalLetters(text);
        Console.WriteLine(outPut);
    }
    /// <summary>
    /// Removes the identical letters.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    static string RemoveIdenticalLetters(string text)
    {
        StringBuilder builder = new StringBuilder();
        char lastChar = '\0';

        for (int i = 0; i < text.Length; i++)
        {
            if (lastChar != text[i])
            {
                builder.Append(text[i]);
                lastChar = text[i];              
            }
        }        
        return builder.ToString();
    }
}