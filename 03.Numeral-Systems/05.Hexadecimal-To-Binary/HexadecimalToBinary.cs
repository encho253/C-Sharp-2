using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
///  Write a program to convert hexadecimal numbers to binary numbers (directly).
/// </summary>
class HexadecimalToBinary
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string hex = Console.ReadLine();
        BigInteger hexToDec = FromHexToDec(hex);
        List<BigInteger> decToBin = FromDecimalToBinary(hexToDec);

        foreach (var item in decToBin)
        {
            Console.Write(item);
        }
    }
    /// <summary>
    /// Froms the hexadecimal to decimal.
    /// </summary>
    /// <param name="hex">The hexadecimal.</param>
    /// <returns></returns>
    static BigInteger FromHexToDec(string hex)
    {
        char[] hexArray = hex.ToCharArray();
        Array.Reverse(hexArray);
        BigInteger dec = 0;

        for (int i = 0; i < hexArray.Length; i++)
        {
            switch (hexArray[i])
            {
                case 'A':
                    dec += 10 * (BigInteger)Math.Pow(16, i);
                    break;
                case 'B':
                    dec += 11 * (BigInteger)Math.Pow(16, i);
                    break;
                case 'C':
                    dec += 12 * (BigInteger)Math.Pow(16, i);
                    break;
                case 'D':
                    dec += 13 * (BigInteger)Math.Pow(16, i);
                    break;
                case 'E':
                    dec += 14 * (BigInteger)Math.Pow(16, i);
                    break;
                case 'F':
                    dec += 15 * (BigInteger)Math.Pow(16, i);
                    break;
                default:
                    dec += int.Parse(hexArray[i].ToString()) * (BigInteger)Math.Pow(16, i);
                    break;
            }
        }
        return dec;
    }
    /// <summary>
    /// Froms the decimal to binary.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <returns></returns>
    static List<BigInteger> FromDecimalToBinary(BigInteger number)
    {
        List<BigInteger> binary = new List<BigInteger>();

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