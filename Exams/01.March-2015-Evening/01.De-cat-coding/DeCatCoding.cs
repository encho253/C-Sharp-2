using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// You will receive a set on letter-numbers (strings) on one line separated with a single space ‘ ‘. 
/// You have to decode every word transferring it from 21-based numeral system to 26-based numeral system 
/// (the whole English alphabet). For example, if you have the word “cb” in decimal system that will be 2*21 + 1*1 = 43. 
/// That in 26-based system is 43 % 26 = 17 = ‘r’, 1 % 26 = 1 = ‘b’. So in 21-based “cb” is “br” in 26.based system.
/// </summary>
class DeCatCoding
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        List<BigInteger> resultInDec = From21ToDec(text);
        List<string> finalList = FromDecTo26(resultInDec);
        foreach (var item in finalList)
        {
            Console.Write(item + " ");
        }
    }

    /// <summary>
    /// From21s to decimal.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns></returns>
    static List<BigInteger> From21ToDec(string[] text)
    {
        BigInteger resultInDec = 0;
        List<BigInteger> listRusult = new List<BigInteger>();
        int counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char[] textToChar = text[i].ToCharArray();

            for (int j = textToChar.Length - 1; j >= 0; j--)
            {
                switch (textToChar[j])
                {
                    case 'a':
                        resultInDec += 0 * BigInteger.Pow(21, counter);
                        break;
                    case 'b':
                        resultInDec += 1 * BigInteger.Pow(21, counter);
                        break;
                    case 'c':
                        resultInDec += 2 * BigInteger.Pow(21, counter);
                        break;
                    case 'd':
                        resultInDec += 3 * BigInteger.Pow(21, counter);
                        break;
                    case 'e':
                        resultInDec += 4 * BigInteger.Pow(21, counter);
                        break;
                    case 'f':
                        resultInDec += 5 * BigInteger.Pow(21, counter);
                        break;
                    case 'g':
                        resultInDec += 6 * BigInteger.Pow(21, counter);
                        break;
                    case 'h':
                        resultInDec += 7 * BigInteger.Pow(21, counter);
                        break;
                    case 'i':
                        resultInDec += 8 * BigInteger.Pow(21, counter);
                        break;
                    case 'j':
                        resultInDec += 9 * BigInteger.Pow(21, counter);
                        break;
                    case 'k':
                        resultInDec += 10 * BigInteger.Pow(21, counter);
                        break;
                    case 'l':
                        resultInDec += 11 * BigInteger.Pow(21, counter);
                        break;
                    case 'm':
                        resultInDec += 12 * BigInteger.Pow(21, counter);
                        break;
                    case 'n':
                        resultInDec += 13 * BigInteger.Pow(21, counter);
                        break;
                    case 'o':
                        resultInDec += 14 * BigInteger.Pow(21, counter);
                        break;
                    case 'p':
                        resultInDec += 15 * BigInteger.Pow(21, counter);
                        break;
                    case 'q':
                        resultInDec += 16 * BigInteger.Pow(21, counter);
                        break;
                    case 'r':
                        resultInDec += 17 * BigInteger.Pow(21, counter);
                        break;
                    case 's':
                        resultInDec += 18 * BigInteger.Pow(21, counter);
                        break;
                    case 't':
                        resultInDec += 19 * BigInteger.Pow(21, counter);
                        break;
                    case 'u':
                        resultInDec += 20 * BigInteger.Pow(21, counter);
                        break;
                    case 'v':
                        resultInDec += 21 * BigInteger.Pow(21, counter);
                        break;
                    case 'w':
                        resultInDec += 22 * BigInteger.Pow(21, counter);
                        break;
                    case 'x':
                        resultInDec += 23 * BigInteger.Pow(21, counter);
                        break;
                    case 'y':
                        resultInDec += 24 * BigInteger.Pow(21, counter);
                        break;
                    case 'z':
                        resultInDec += 25 * BigInteger.Pow(21, counter);
                        break;
                }
                counter++;
            }
            listRusult.Add(resultInDec);
            resultInDec = 0;
            counter = 0;
        }
        return listRusult;
    }
    /// <summary>
    /// Froms the decimal to26.
    /// </summary>
    /// <param name="resultInDec">The result in decimal.</param>
    /// <returns></returns>
    static List<string> FromDecTo26(List<BigInteger> resultInDec)
    {
        List<string> finalList = new List<string>();
        string word = null;

        for (int i = 0; i < resultInDec.Count; i++)
        {
            BigInteger remainder = 0;
            BigInteger result = resultInDec[i];

            while (result != 0)
            {
                remainder = result % 26;

                switch (remainder.ToString())
                {
                    case "0":
                        word += "a";
                        break;
                    case "1":
                        word += "b";
                        break;
                    case "2":
                        word += "c";
                        break;
                    case "3":
                        word += "d";
                        break;
                    case "4":
                        word += "e";
                        break;
                    case "5":
                        word += "f";
                        break;
                    case "6":
                        word += "g";
                        break;
                    case "7":
                        word += "h";
                        break;
                    case "8":
                        word += "i";
                        break;
                    case "9":
                        word += "j";
                        break;
                    case "10":
                        word += "k";
                        break;
                    case "11":
                        word += "l";
                        break;
                    case "12":
                        word += "m";
                        break;
                    case "13":
                        word += "n";
                        break;
                    case "14":
                        word += "o";
                        break;
                    case "15":
                        word += "p";
                        break;
                    case "16":
                        word += "q";
                        break;
                    case "17":
                        word += "r";
                        break;
                    case "18":
                        word += "s";
                        break;
                    case "19":
                        word += "t";
                        break;
                    case "20":
                        word += "u";
                        break;
                    case "21":
                        word += "v";
                        break;
                    case "22":
                        word += "w";
                        break;
                    case "23":
                        word += "x";
                        break;
                    case "24":
                        word += "y";
                        break;
                    case "25":
                        word += "z";
                        break;
                }
                remainder = 0;
                result /= 26;
            }
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string finalWord = new string(arr);
            finalList.Add(finalWord);
            word = null;
        }
        return finalList;
    }
}