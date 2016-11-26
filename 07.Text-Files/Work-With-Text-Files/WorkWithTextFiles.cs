using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class WorkWithTextFiles
{
    static void Main()
    {
        string textFileOne = @"../../TextFiles/01.textFile.txt";
        string textFileTwo = @"../../TextFiles/02.textFile.txt";

        string[] readFromTextFile = ReadFromTextFile(textFileOne);
        List<string> sortByFirstTwoLetters = SortWordsByFirstTwoLetters(readFromTextFile);
        WriteToFile(textFileTwo, sortByFirstTwoLetters);
    }
    static string[] ReadFromTextFile(string textFile)
    {
        StreamReader readFileOne = new StreamReader(textFile);

        using (readFileOne)
        {
            string textFromFile = readFileOne.ReadToEnd();
            string[] wordFromFail = textFromFile.Split('\n').Select(n => Convert.ToString(n)).ToArray();
            for (int i = 0; i < wordFromFail.Length; i++)
            {
              wordFromFail[i] = Regex.Replace(wordFromFail[i], @"\t|\n|\r", "");
            }           
            return wordFromFail;
        }
    }
    static List<string> SortWordsByFirstTwoLetters(string[] wordFromFail)
    {
        List<string> listWords = new List<string>();

        for (int i = 0; i < wordFromFail.Length; i++)
        {
            char[] words = wordFromFail[i].ToCharArray();
            if (words[0] + 1 == words[1])
            {
                listWords.Add(wordFromFail[i]);
            }
        }
        listWords = listWords.Distinct().ToList();      
        return listWords;
    }
    static void WriteToFile(string textFileTwo, List<string> listWords)
    {
        listWords.Sort();
        listWords.Reverse();
        Console.OutputEncoding = Encoding.UTF8;
        StreamWriter streamWriter = new StreamWriter(textFileTwo, false, Encoding.UTF8);
        using (streamWriter)
        {
            foreach (var item in listWords)
            {
                streamWriter.WriteLine(item);
                Console.WriteLine(item);
            }
        }
    }
}