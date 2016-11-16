using System;

/// <summary>
/// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
/// several neighbour elements located on the same line, column or diagonal. Write a program that finds 
/// the longest sequence of equal strings in the matrix and prints its length.
/// </summary>
class SequenceInMatrix
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string size = Console.ReadLine();
        string[] sizeString = size.Split(' ');
        int[,] array = new int[int.Parse(sizeString[0]), int.Parse(sizeString[1])];
        int counter = 0;
        int bestSequence = 0;
        bool firstTime = true;
        int diagonal = 2;
        int lengt = 0;
        int jIndex = 1;
        //
        for (int i = 0; i < array.GetLength(0); i++)
        {
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(arrayNumbers[j]);
            }
        }
        //
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 1; j < array.GetLength(0); j++)
            {
                if (array[j - 1, i] == array[j, i])
                {
                    if (firstTime)
                    {
                        counter += 1;
                        firstTime = false;
                    }
                    counter++;
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                }
            }
            counter = 0;
            firstTime = true;
        }
        //
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[i, j - 1] == array[i, j])
                {
                    if (firstTime)
                    {
                        counter += 1;
                        firstTime = false;
                    }
                    counter++;
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                }
            }
            counter = 0;
            firstTime = true;
        }
        //
        if (array.GetLength(0) > array.GetLength(1))
        {
            lengt = array.GetLength(1);
        }
        else
        {
            lengt = array.GetLength(0);
        }
        for (int i = 1; i < lengt; i++)
        {
            for (int j = 1; j < diagonal; j++)
            {
                if (array[i - j + 1, jIndex - 1] == array[i - j, jIndex])
                {
                    if (firstTime)
                    {
                        counter += 1;
                        firstTime = false;
                    }
                    counter++;
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                }
                jIndex++;
            }
            jIndex = 1;
            diagonal++;
            firstTime = true;
            counter = 0;
        }

        //
        diagonal = 2;

        for (int i = lengt - 2; i >= 0; i--)
        {
            for (int j = 1; j < diagonal; j++)
            {
                if (array[i + j - 1, jIndex - 1] == array[i + j, jIndex])
                {
                    if (firstTime)
                    {
                        counter += 1;
                        firstTime = false;
                    }
                    counter++;
                }
                if (counter > bestSequence)
                {
                    bestSequence = counter;
                }
                jIndex++;
            }
            jIndex = 1;
            diagonal++;
            firstTime = true;
            counter = 0;
        }       
        Console.WriteLine(bestSequence);
    }
}