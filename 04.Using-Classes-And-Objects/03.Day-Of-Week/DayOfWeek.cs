using System;

/// <summary>
/// Write a program that prints to the console which day of the week is today. Use System.DateTime.
/// </summary>
class DayOfWeek
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        DateTime today = new DateTime();

        Console.WriteLine(today.DayOfWeek);
    }    
}