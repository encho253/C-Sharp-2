using System;

/// <summary>
/// On the only line you will receive an expression
/// </summary>
class CorrectBrackets
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string text = Console.ReadLine();
        bool isTrue = CheckBracketsArePutCorrectly(text);

        if (isTrue)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
    /// <summary>
    /// Checks the brackets are put correctly.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    static bool CheckBracketsArePutCorrectly(string text)
    {
        bool isTrue = true;
        char[] textArray = text.ToCharArray();
        int rightBracket = 0;
        int leftBracket = 0;

        for (int i = 0; i < textArray.Length; i++)
        {
            if (textArray[i] == '(')
            {
                rightBracket++;
            }
            else if (textArray[i] == ')')
            {
                leftBracket++;
            }
        }
        if (leftBracket == rightBracket)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
        return isTrue;
    }
}