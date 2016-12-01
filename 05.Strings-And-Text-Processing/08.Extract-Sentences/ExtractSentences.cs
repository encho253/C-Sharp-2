using System;
using System.Text;

/// <summary>
/// Write a program that extracts from a given text all sentences containing given word.
/// </summary>
class ExtractSentences
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        SentencesContainingGivenWord(text, pattern);
    }
    /// <summary>
    /// Sentenceses the containing given word.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <param name="pattern">The pattern.</param>
    static void SentencesContainingGivenWord(string text, string pattern)
    {
        string[] sentencesArray = text.Split('.');

        StringBuilder builder = new StringBuilder();
        StringBuilder finalBuilder = new StringBuilder();

        foreach (var item in sentencesArray)
        {
            builder.Clear();

            for (int j = 0; j < item.Length; j++)
            {
                if (Char.IsLetter(item[j]) == false)
                {
                    builder.Append(item[j]);
                }
            }
            char[] splitPattern = builder.ToString().ToCharArray();
            string[] words = item.Split(splitPattern);

            if (Array.IndexOf(words, pattern) > -1)
            {
                finalBuilder.Append(item.Trim());
                finalBuilder.Append(". ");
            }
        }
        Console.WriteLine(finalBuilder.ToString().Trim());
    }
}