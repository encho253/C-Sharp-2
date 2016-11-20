using System;
using System.Numerics;

/// <summary>
/// Write a program that converts a hexadecimal number N to its decimal representation.
/// </summary>
class HexadecimalToDecimal
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string hex = Console.ReadLine();
        BigInteger dec = FromHexToDec(hex);
        Console.WriteLine(dec);
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
}
