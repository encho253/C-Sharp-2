using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string textFileOne = @"../../TextFiles/text1.txt";

        StreamReader reader = new StreamReader(textFileOne);

        using (reader)
        {
            string textFromFile = reader.ReadToEnd();

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(textFromFile);
        }
    }
}