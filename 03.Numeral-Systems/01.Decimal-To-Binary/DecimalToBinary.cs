using System;
using System.Collections.Generic;

/// <summary>
/// Write a program that converts a decimal number N to its binary representation.
/// </summary>
class DecimalToBinary
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        List<long> binaryNumber = FromDecimalToBinary(decimalNumber);

        foreach (var item in binaryNumber)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
    /// <summary>
    /// Froms the decimal to binary.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns></returns>
    static List<long> FromDecimalToBinary(long number)
    {
        List<long> binary = new List<long>();

        while (number > 0)
        {
            if (number % 2 == 0)
            {
                number /= 2;
                binary.Add(0);
            }
            else
            {
                number /= 2;
                binary.Add(1);
            }
        }
        binary.Reverse();

        return binary;
    }
}