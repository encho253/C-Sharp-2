using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class WorkWithTextFiles
{
    static void Main()
    {
        string textFileOne = @"../../TextFiles/01.textFile.txt";
        string textFileTwo = @"../../TextFiles/02.textFile.txt";

        string[] readFromTextFile = ReadFromTextFile(textFileOne);
        List<string> sortByFirstTwoLetters = SortWordsByFirstTwoLetters(readFromTextFile);
        List<string> removeEqualWords = RemoveEqualWordsInList(sortByFirstTwoLetters);
        WriteToFile(textFileTwo, removeEqualWords);
    }
    static string[] ReadFromTextFile(string textFile)
    {
        StreamReader readFileOne = new StreamReader(textFile);
        
        using (readFileOne)
        {
            string textFromFile = readFileOne.ReadToEnd();
            string[] wordFromFail = textFromFile.Split('\n').Select(n => Convert.ToString(n)).ToArray();

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
        return listWords;
    }
    static List<string> RemoveEqualWordsInList(List<string> listWords)
    {
        int counter = 1;

        for (int i = 0; i < listWords.Count; i++)
        {
            for (int j = counter; j < listWords.Count; j++)
            {
                if (listWords[i] == listWords[j])
                {
                    listWords.RemoveAt(j);
                    j--;
                }
            }
            counter++;
        }
        return listWords;
    }
    static void WriteToFile(string textFileTwo,List<string> listWords) 
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