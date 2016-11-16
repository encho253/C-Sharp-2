using System;

/// <summary>
/// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
/// that has maximal sum of its elements. Print that sum.
/// </summary>
class MaximalSum
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string size = Console.ReadLine();
        string[] sizeString = size.Split(' ');
        int[,] array = new int[int.Parse(sizeString[0]), int.Parse(sizeString[1])];
        int sum = 0;
        int bestSum = 0;
        int counterRow = 0;
        int counterCol = 0;
        bool firstTime = true;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(arrayNumbers[j]);
            }
        }

        while ((counterRow + 3) <= array.GetLength(0) && (counterCol + 3) <= array.GetLength(1))
        {
            for (int i = counterRow; i < counterRow + 3; i++)
            {
                for (int j = counterCol; j < counterCol + 3; j++)
                {
                    sum += array[i, j];
                }
            }
            if (firstTime)
            {
                bestSum = sum;
                firstTime = false;
            }
            else if (sum > bestSum)
            {
                bestSum = sum;
            }
            if ((counterCol + 4) <= array.GetLength(1))
            {
                counterCol++;
            }
            else if ((counterCol + 4) > array.GetLength(1))
            {
                counterCol = 0;
                counterRow++;
            }
            sum = 0;
        }
        Console.WriteLine(bestSum);
    }
}