using System;
using System.Numerics;


/// <summary>
/// Write a program that converts a binary number N to its decimal representation.
/// </summary>
class BinaryToDecimal
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        char[] binaryInCharArray = binaryNumber.ToCharArray();
        BigInteger dec = FromBinToDec(binaryInCharArray);

        Console.WriteLine(dec);
    }
    /// <summary>
    /// Froms the bin to decimal.
    /// </summary>
    /// <param name="binaryInCharArray">The binary in character array.</param>
    /// <returns></returns>
    static BigInteger FromBinToDec(char[] binaryInCharArray)
    {
        BigInteger dec = 0;
        Array.Reverse(binaryInCharArray);

        for (int i = 0; i < binaryInCharArray.Length; i++)
        {
            int fromCharToInt = int.Parse(binaryInCharArray[i].ToString());          
            dec += fromCharToInt * (BigInteger)Math.Pow(2, i);
        }

        return dec;
    }
}