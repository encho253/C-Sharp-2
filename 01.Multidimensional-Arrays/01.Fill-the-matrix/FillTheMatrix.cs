using System;

/// <summary>
/// Write a program that fills and prints a matrix of size (n, n) as shown below.
/// </summary>
class FillTheMatrix
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string matrixModul = Console.ReadLine();
        int[,] matrix = new int[size, size];
        int number= 1;    
        int jIndex = 1;
        int diagonal = 1;
        int counter = 1;

        if (matrixModul == "a")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = number;
                    number++;
                }
            }
        }
        else if (matrixModul == "b")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[j, i] = number;
                        number++;
                    }
                }
                else
                {
                    for (int k = matrix.GetLength(1) - 1; k >= 0; k--)
                    {
                        matrix[k, i] = number;
                        number++;
                    }
                }
            }
        }
        else if (matrixModul == "c")
        {
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < diagonal; j++)
                {
                    if (j != 0)
                    {
                        matrix[i + j, j] = number;
                    }
                    else
                    {
                        matrix[i, j] = number;
                    }
                    number++;
                }
                diagonal++;
            }
            while (diagonal > 0)
            {
                int i = 0;
                diagonal--;
                for (int j = diagonal - 1; j > 0; j--)
                {
                    matrix[i, jIndex] = number;
                    i++;
                    number++;
                    jIndex++;                   
                }
                counter++;
                jIndex = counter;
            }          
        }
        else if (matrixModul == "d")
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(0) - i; j++)
                {
                    matrix[j,i] = number;
                    number++;
                }
                for (int j = i + 1; j < matrix.GetLength(1) - i; j++)
                {
                    matrix[(matrix.GetLength(1) - i - 1), j] = number;
                    number++;
                }
                for (int j = (matrix.GetLength(1) - i - 1); j > i; j--)
                {
                    matrix[j - 1,(matrix.GetLength(1) - i - 1)] = number;
                    number++;
                }
                for (int j = (matrix.GetLength(1) - i - 2); j > i; j--)
                {
                    matrix[i,j] = number;
                    number++;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write(matrix[i, j]);

                if (j + 1 == matrix.GetLength(0))
                {
                    break;
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}