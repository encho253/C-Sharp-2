using System;

/// <summary>
/// Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.
/// </summary>
class SayHello
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        AskName(Console.ReadLine());
    }

    /// <summary>
    /// Asks the name.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    static void AskName(string firstName)
    {
        Console.WriteLine("Hello, {0}!",firstName);
    }
}