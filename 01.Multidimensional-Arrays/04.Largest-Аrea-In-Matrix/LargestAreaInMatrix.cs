using System;

class LargestAreaInMatrix
{
    static void Main()
    {
        int[,] matrix = InputData();

        LargestArea(matrix);
    }

    static int[,] InputData()
    {
        string size = Console.ReadLine();
        string[] sizeString = size.Split(' ');
        int[,] matrix = new int[int.Parse(sizeString[0]), int.Parse(sizeString[1])];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(arrayNumbers[j]);
            }
        }
        return matrix;
    }

    static void LargestArea(int[,] matrix)
    {
        int numberOfElements = matrix.GetLength(0) * matrix.GetLength(1);
        int equal = 0;
        int bestEqual = 0;


        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            for (int m = 0; m < matrix.GetLength(1); m++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[k,m] == matrix[i,j])
                        {
                            equal++;
                        }
                    }                    
                }
                if (equal > bestEqual)
                {
                    bestEqual = equal;
                }
                equal = 0;
            }
        }
        Console.WriteLine(bestEqual);
    }
}