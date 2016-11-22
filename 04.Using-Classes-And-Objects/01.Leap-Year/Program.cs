using System;

/// <summary>
/// Write a program that reads a year from the console and checks whether it is a leap one.
/// </summary>
class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}