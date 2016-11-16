using System;

/// <summary>
/// Write a method that returns the last digit of given integer as an English word. 
/// Write a program that reads a number and prints the result of the method.
/// </summary>
class EnglishDigit
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        ReturnLastDigitOfInteger(int.Parse(Console.ReadLine()));
    }

    /// <summary>
    /// Returns the last digit of integer.
    /// </summary>
    /// <param name="inputNumber">The input number.</param>
    static void ReturnLastDigitOfInteger(int inputNumber)
    {
        switch (inputNumber % 10)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;

            default:
                break;
        }
    }
}