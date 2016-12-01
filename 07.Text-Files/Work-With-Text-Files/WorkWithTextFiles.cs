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
        string textFileOne = @"../../TextFiles/01.textFile.txt"; // v promenliva ot tip string zapisvame patq na faila pod formata na string
        string textFileTwo = @"../../TextFiles/02.textFile.txt";

        List<string> readFromTextFile = new List<string>();// sazdavame nova promenliva ot tip List ot stringove.
        readFromTextFile = ReadFromTextFile(textFileOne); //v sazdadenata promenliva List ot stringove zapisvame varnatiq List ot stringove ot metoda ReadFromTextFile.Kato pri izvikvaneto na metoda ReadFromTextFile() mu podavame kato parametar stringa s patq do textoviq fail.
        List<string> sortByFirstTwoLetters = new List<string>(); // sazdavame si nov List ot stringove , v koito shte zapazim veche sortiranite dumi po parvite dve bukvi ,kato sme mahnali povtarqshtite se.
        sortByFirstTwoLetters = SortWordsByFirstTwoLetters(readFromTextFile); //v sazdadenata promenliva List ot stringove izvikvame metoda SortWordsByFirstTwoLetters(readFromTextFile), kato mu podavame kato parametar Lista s nesortiranite dumi izvlecheni ot textoviq fail, chrez parviq metod.Rezultatat ot metoda go zapisvame v novosazdadeniq list ot stringove
        WriteToFile(textFileTwo, sortByFirstTwoLetters); // shte zapishem veche gotoviq List vav vtoriq textovi fail chrez napraveniq ot nas metod WriteToFile(textFileTwo, sortByFirstTwoLetters); , kato mu podavame dva parametara -> stringa sas patq do vtoriq textovi fail i lista s dumi -> sortByFirstTwoLetters
    }
    static List<string> ReadFromTextFile(string textFile) //metod koito priema kato parametar patq do faila pod formata na string 
    {
        StreamReader readFileOne = new StreamReader(textFile); //StreamReader - class, chrez koito izchitame informaciqta ot textoviq fail.Za celta sazdavem nov obekt ot tozi class, chrez koito obekt shte dostapvame do vsichki povedeniq ot tozi class.

        using (readFileOne) // using kazva -> izpolzvai obektat readFileOne,poneje takav e sintaksisa za izchitane na textovi fail
        {
            string textFromFile = readFileOne.ReadToEnd(); //sazdavame promenliva ot tip string v koqto zapisvame celq izcheten text ot faila kato izpolzvame metoda ReadToEnd() , izvikan prez obekta readFileOne, koito sme sazdali predi tova ot clasa StreamReader
            string pattern = @"[?!-.\r\n,\s]"; //sazdavame si promenliva ot tip string v koeto shte pazim nqkakav string koito shte ni sluji kato shablon (regulqren izraz) v clasa Regex.
            Regex regexText = new Regex(pattern); //sazdavame si obekt ot clas Regex (clas za textoobrabotka,rabota s regulqrni izrazi)

            List<string> wordFromFail = new List<string>(); //sazdavame List ot stringove . v koito shte zapisvame vsqka otdelna duma splitnata chrez Regex clasa.
            wordFromFail = regexText.Split(textFromFile).ToList(); // sega zapochvame da slitvame texta ot textoviq fail chrez sazdadeniq obekt ot clas Regex kato izpolzvame sazdadeniq ot nas shablon zapisan v promenlivata pattern.Taka shte otdelim samo dumite ot textoviq fail.Vsqka otdelna duma shte ni se pazi na nova pozciq v Lista.
            for (int i = 0; i < wordFromFail.Count; i++) //poneje ostanaha nqkakvi "" -> prazni redove v nashiq List ot dumi, shte gi premahnem sas sledniq for() cikal
            {
                if (wordFromFail[i] == "") // ako sreshtnem element v nashiq list i raven na ""
                {
                    wordFromFail.Remove(wordFromFail[i]);// go premahvame ot Lista
                    i--;//ako sme mahnali elemnta ot lista namalqme elemntite s 1
                }
            }
            return wordFromFail; //vrashtame nashiq list s dumi kato rezultat ot izpalnenieto na metoda
        }
    }
    static List<string> SortWordsByFirstTwoLetters(List<string> wordFromFail) //sazdavame metod koito priema kato parametar nesortiraniq List ot dumi varnat ot parviq metod, i vrashta List sas sortiranite dumi
    {
        List<string> listWords = new List<string>();

        for (int i = 0; i < wordFromFail.Count; i++)//s tozi for cikal dostapvame do vseki element ot neseortiraniq list s dumi, kato vseki element ot tozi list pazi otdelna duma
        {
            char[] words = wordFromFail[i].ToCharArray();//vsqka otdelna duma q zapisvame v char masiv, kato vsqka bukva ot tazi duma shte se zapishe na otdelen element ot tozi char masiv.
            if (words[0] + 1 == words[1]) // kato uvelichim parvata bukva na dumata ,koqto se pazi na nuleva poziciq, s 1 proverqvame dali e ravna na vtorata bukva v dumata , koqto se pazi na poziciq 1 v char masiva.
            {
                listWords.Add(wordFromFail[i]); //Ako se izpalni if-a dobavi dumata na poziciq i ot nesortiraniq List<string> v novosazdadeniq List 
            }
        }
        listWords = listWords.Distinct().ToList();  //Premahvame ednakvite dumi vav veche popalneniq List chrez metoda Distinct()    
        return listWords; //vrashtame popalneniq List
    }
    static void WriteToFile(string textFileTwo, List<string> listWords) //sazdavame si nov metod koito priema dva parametara(string s patq do vtoriq textovi fail i list s dumi) i zapisva v textovi fail sortiran List s dumi.
    {
        listWords.Sort(); //sortirame lista s dumi lexikogravski (po uslovie)
        listWords.Reverse(); //zavartame go otzad napred (po uslovie se iska da e sortiran ot bukvata Я kam А )
        Console.OutputEncoding = Encoding.UTF8;//trqbva ni za da pishem na kirilica po konzolata
        StreamWriter streamWriter = new StreamWriter(textFileTwo, false, Encoding.UTF8); //izpolzvame clasa StreamWriter za da pishem po konzolata, kato sazdavame nov obekt ot tozi klas chrez koito shte dostapvame vsichki povedeniq na clasa.Pri sazdavaneto na noviq obekt clasa konstruktor ot klasa StreamWriter iziskva da vavedem string s patq do textoviq fail v koito shte zapisvame neshto.Dobavqm i false, Encoding.UTF8 za da moje da pishem na kirilica v textoviq fail
        using (streamWriter) //otnovo izpolzvame using zaedno s novosazdadeniq obekt kakto beshe i pri cheteneto ot fail
        {
            foreach (var item in listWords) //s foreach cikal kazvame vsqka duma ot lista listWord
            {
                streamWriter.WriteLine(item);//Da se zapisva vav vtoriq textovi fail
                Console.WriteLine(item);//pechatim i na konzolata da vidim dali sme rabotili vqrno
            }
        }
    }
}