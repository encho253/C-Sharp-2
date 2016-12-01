using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SingingCats
{
    static void Main(string[] args)
    {
        ReadData();
    }
    public static void ReadData()
    {
        string catsString = Console.ReadLine();
        int cats = Int32.Parse(Regex.Match(catsString, @"\d+").Value);

        string songsString = Console.ReadLine();
        int songs = Int32.Parse(Regex.Match(songsString, @"\d+").Value);

        bool[] arraySongs = new bool[songs];
        bool[] arrayCats = new bool[cats];
        int[,] table = new int[2, songs];

        int catCounter = 0;
        int songCounter = 0;
        int minSongs = 0;

        StringBuilder builder = new StringBuilder();

        do
        {
            string text = Console.ReadLine();

            if (text != "Mew!")
            {
                int catNumber = Int32.Parse(Regex.Match(text, @"\d+").Value);

                char[] reverse = text.ToCharArray();
                Array.Reverse(reverse);
                text = new string(reverse);
                int songNumber = Int32.Parse(Regex.Match(text, @"\d+").Value);

                if (arraySongs[songNumber - 1] == true && arrayCats[catNumber - 1] == false)
                {
                    catCounter++;
                    table[1, songNumber - 1] += catCounter;
                    arrayCats[catNumber - 1] = true;                 
                }
                else if (arraySongs[songNumber - 1] == false && arrayCats[catNumber - 1] == false)
                {
                    catCounter++;
                    songCounter++;
                    minSongs++;
                    arrayCats[catNumber - 1] = true;
                    arraySongs[songNumber - 1] = true;
                }
                else if (arrayCats[catNumber - 1] == true)
                {
                    minSongs--;
                    if (arraySongs[songNumber - 1] == false)
                    {
                        songCounter++;
                    }
                }
                else if (arraySongs[songNumber - 1] == true && arrayCats[catNumber - 1] == false)
                {
                    catCounter++;
                    arrayCats[catNumber - 1] = true;
                }
                if (table[1, songNumber - 1] == cats && songCounter == songs)
                {
                    minSongs = 1;
                }
            }
            else
            {
                break;
            }
        } while (true);

        Calculation(arraySongs, arrayCats, table,catCounter,songCounter,minSongs);
    }
    static void Calculation(bool[] arrSongs, bool[] arrCat, int[,] tabl,int catCounter,int songCounter,int minSongs)
    {
        List<int> numbers = new List<int>();


        for (int i = 0; i < arrSongs.Length; i++)
        {
            if (arrSongs[i] != true)
            {
                Console.WriteLine("No concert!");
                return;
            }
        }
        for (int i = 0; i < arrCat.Length; i++)
        {
            if (arrCat[i] != true)
            {
                Console.WriteLine("No concert!");
                return;
            }
        }
        Console.WriteLine(minSongs);       
    }
}