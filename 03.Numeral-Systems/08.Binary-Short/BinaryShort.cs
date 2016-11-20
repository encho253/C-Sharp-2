using System;
using System.Collections.Generic;

/// <summary>
/// Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).
/// </summary>
class BinaryShort
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
        bool isNegative = false;
        int bitCounter = 0;
        int keepInMind = 0;
        int oneBit = 1;

        if (number < 0)
        {
            number *= -1;
            isNegative = true;
        }
        while (number > 0)
        {
            if (number % 2 == 0)
            {
                number /= 2;
                binary.Add(0);
                bitCounter++;
            }
            else
            {
                number /= 2;
                binary.Add(1);
                bitCounter++;
            }
        }       
        if (isNegative)
        {
            //Еquated to '0' the oder (16 - bitCounter) bits
            for (int i = 0; i < 16 - bitCounter; i++)
            {
                binary.Add(0);
            }
            /////////////////
            // 1's Complement
            for (int i = 0; i < 16; i++)
            {
                if (binary[i] == 0)
                {
                    binary[i] = 1;
                }
                else
                {
                    binary[i] = 0;
                }
            }
            //////////////
            // 2's complement
            for (int i = 0; i < 16; i++)
            {
                if ((binary[i] + oneBit + keepInMind) == 2)
                {
                    binary[i] = 0;
                    keepInMind = 1;
                }
                else if((binary[i] + oneBit + keepInMind) == 1)
                {
                    binary[i] = 1;
                    keepInMind = 0;
                }
                else if((binary[i] + oneBit + keepInMind) == 0)
                {
                    binary[i] = 0;
                }
                oneBit = 0;
            }
            /////////////
        }
        else
        {
            for (int i = 0; i < 16 - bitCounter; i++)
            {
                binary.Add(0);
            }
        }
        binary.Reverse();

        return binary;
    }
}